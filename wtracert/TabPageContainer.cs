using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace kursach
{
    public partial class TabPageContainer : UserControl
    {
        public TabPage parent;
        public List<IPAddress> newPath;
        public List<IPAddress> oldPath;
        public Dictionary<IPAddress,CollapsiblePanel> curPanelsByIP;
        public List<CollapsiblePanel> curPanelsByPosition;
        public bool paused = false;
        public string hostAddress;
        public int currentHeight;
        public int offsetHeight;
        public class pingInfoNeed
        {
            public TabPageContainer tabPageCont;
            public int hop;
            public IPAddress destIP;
            public DateTime timeSent;
        }
        public class SaveInfoIP
        {
            public int hop;
            public string IPAddress;
            public int min;
            public int max;
            public int avg;
        }
        public class SaveInfoPath
        {
            public string hostAddress;
            public DateTime time;
            public SaveInfoIP[] ips;
        }
        public TabPageContainer(TabPage tabPage)
        {
            parent = tabPage;
            hostAddress = "";
            InitializeComponent();
            curPanelsByIP = new Dictionary<IPAddress, CollapsiblePanel>();
            curPanelsByPosition = new List<CollapsiblePanel>(30);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (paused)
            {
                timer10s.Enabled = true;
                paused = false;
                return;
            }
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            hostAddress = textBox1.Text;
            parent.Text = hostAddress + "   ";
            label1.Text = "Попытка получить путь следования пакетов";
            timer10s.Enabled = true;
            timer10s_Tick(timer1s, EventArgs.Empty);
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            timer1s.Enabled = true;
        }
        public static void IsDestinationReachable(object sender,PingCompletedEventArgs e)
        {
            
            if(e.Error != null)
            {
                Exception exc = e.Error;
                while (exc.InnerException != null)
                    exc = exc.InnerException;
                ((TabPageContainer)e.UserState).label1.Text = exc.Message;
                ((TabPageContainer)e.UserState).button3_Click(null, EventArgs.Empty);
                return;
            }
            if (e.Reply.Status != IPStatus.Success)
            {
                ((TabPageContainer)e.UserState).label1.Text = "Точка назначения недостижима";
                return;
            }
            int hopCount;
            if (e.Reply.Options.Ttl < 64)
            {
                hopCount = 65 - e.Reply.Options.Ttl;
            }
            else
            {
                hopCount = 129 - e.Reply.Options.Ttl;
            }
            ((TabPageContainer)e.UserState).newPath = new List<IPAddress>(hopCount);
            for (int i = 0; i < hopCount; i++)
            {
                ((TabPageContainer)e.UserState).newPath.Add(IPAddress.None);
            }
            for (int i = 0; i < hopCount; i++)
            {
                pingInfoNeed info = new pingInfoNeed();
                info.tabPageCont = (TabPageContainer)e.UserState;
                info.hop = i;
                info.destIP = null;
                info.timeSent = DateTime.Now;
                Ping pingInterface = new Ping();
                pingInterface.PingCompleted += new PingCompletedEventHandler(PathReciever);
                PingOptions newOption = new PingOptions(i + 1, false);
                pingInterface.SendAsync(e.Reply.Address, 4, new byte[32], newOption, info);
            }
            
        }
        public static void PathReciever(object sender, PingCompletedEventArgs e)
        {
            pingInfoNeed info = (pingInfoNeed)e.UserState;
            if (e.Error != null)
            {
                info.tabPageCont.newPath[info.hop] = IPAddress.None;
                return;
            }
            if (e.Reply.Status == IPStatus.Success || e.Reply.Status == IPStatus.TtlExpired)
            {
                info.tabPageCont.newPath[info.hop] = e.Reply.Address;
                return;
            }
            info.tabPageCont.newPath[info.hop] = IPAddress.None;
        }
        private void timer10s_Tick(object sender, EventArgs e)
        {
            if (newPath != null)
            {
                List<IPAddress> pathClear = new List<IPAddress>();
                foreach (var i in newPath)
                {
                    if (i == IPAddress.None)
                    {
                        pathClear.Add(i);
                    }
                    else
                    {
                        if (!pathClear.Contains(i))
                        {
                            pathClear.Add(i);
                        }
                    }
                }
                newPath = pathClear;
                if (oldPath != null)
                {
                    List<IPAddress> newOldPath = new List<IPAddress>(newPath.Count);
                    for (int i = 0; i < newPath.Count; i++ )
                    {
                        newOldPath.Add(IPAddress.None);
                    }
                    for (int i = 0; i < newPath.Count;i++ )
                    {
                        if (newPath[i] != IPAddress.None)
                        {
                            if (i > oldPath.Count-1)
                            {
                                newOldPath[i] = newPath[i];
                            }
                            else
                            {
                                newOldPath[i] = newPath[i];
                            }
                        }
                        else
                        {
                            if (i < oldPath.Count && oldPath[i] != IPAddress.None)
                            {
                                newOldPath[i] = oldPath[i];
                            }
                        }
                    }
                    for (int i = 0; i < newOldPath.Count; i++)
                    {
                        if (newOldPath[i] != IPAddress.None)
                        {
                            if (curPanelsByIP.ContainsKey(newOldPath[i]))
                            {
                                var collapsiblePanel = curPanelsByIP[newOldPath[i]];
                                int curPosition = curPanelsByPosition.FindIndex(val => val == collapsiblePanel);
                                if (i != curPosition && i < curPanelsByPosition.Count)
                                {
                                    CollapsiblePanelContainer.Controls.Remove(curPanelsByPosition[curPosition]);
                                    curPanelsByPosition.RemoveAt(curPosition);
                                    for(int j = i; j < curPanelsByPosition.Count;j++)
                                    {
                                        CollapsiblePanelContainer.Controls.Remove(curPanelsByPosition[j]);
                                    }
                                    if (i < curPanelsByPosition.Count)
                                    {
                                        curPanelsByPosition.Insert(i, collapsiblePanel);
                                        for (int j = i; j < curPanelsByPosition.Count; j++)
                                        {
                                            CollapsiblePanelContainer.Controls.Add(curPanelsByPosition[j]);
                                        }
                                    }
                                    else
                                    {
                                        curPanelsByPosition.Add(collapsiblePanel);
                                        CollapsiblePanelContainer.Controls.Add(collapsiblePanel);
                                    }
                                    collapsiblePanel.Dock = DockStyle.Top;
                                }
                            }
                            else
                            {
                                var collapsiblePanel = new CollapsiblePanel();
                                collapsiblePanel.SetTimer(timer1s);
                                collapsiblePanel.SetName(newOldPath[i].ToString());
                                curPanelsByIP.Add(newOldPath[i], collapsiblePanel);
                                for (int j = i; j < curPanelsByPosition.Count; j++)
                                {
                                    CollapsiblePanelContainer.Controls.Remove(curPanelsByPosition[j]);
                                }
                                if (i < curPanelsByPosition.Count)
                                {
                                    curPanelsByPosition.Insert(i, collapsiblePanel);
                                }
                                else
                                {
                                    curPanelsByPosition.Add(collapsiblePanel);
                                }
                                for (int j = i; j < curPanelsByPosition.Count; j++)
                                {
                                    CollapsiblePanelContainer.Controls.Add(curPanelsByPosition[j]);
                                }
                                collapsiblePanel.Dock = DockStyle.Top;
                                collapsiblePanel.Height = 22;
                                collapsiblePanel.changedHeight = new EventHandler(ChangedHeight);
                                currentHeight += 22;
                            }
                        }
                    }
                    for (int j = 0; j < oldPath.Count; j++)
                    {
                        if (oldPath[j] != IPAddress.None)
                        {
                            if (!newOldPath.Contains(oldPath[j]))
                            {
                                if(curPanelsByIP.ContainsKey(oldPath[j]))
                                {
                                    var panel = curPanelsByIP[oldPath[j]];
                                    curPanelsByIP.Remove(oldPath[j]);
                                    CollapsiblePanelContainer.Controls.Remove(panel);
                                    while(curPanelsByPosition.Remove(panel));
                                    currentHeight -= panel.Height;
                                }
                                
                            }
                        }
                    }
                    oldPath = newOldPath;
                   
                }
                else
                {
                    label1.Text = "";
                    label1.Visible = false;
                    oldPath = new List<IPAddress>(newPath.Count);
                    for (int i = 0; i < newPath.Count; i++)
                    {
                        oldPath.Add(IPAddress.None);
                    }
                    currentHeight = 0;
                    for (int i = 0; i < newPath.Count; i++)
                    {
                        oldPath[i] = newPath[i];
                        if (newPath[i] != IPAddress.None)
                        {
                            CollapsiblePanel panel = new CollapsiblePanel();
                            panel.SetTimer(timer1s);
                            panel.SetName(newPath[i].ToString());
                            curPanelsByIP[newPath[i]] = panel;
                            curPanelsByPosition.Add(panel);
                            CollapsiblePanelContainer.Controls.Add(panel);
                            panel.Dock = DockStyle.Top;
                            panel.Height = 22;
                            panel.changedHeight = new EventHandler(ChangedHeight);
                            currentHeight += 22;
                        }
                    }
                    RecalculateScrollBar();
                }
            }
            Ping pingInterface = new Ping();
            pingInterface.PingCompleted += new PingCompletedEventHandler(IsDestinationReachable);
            pingInterface.SendAsync(hostAddress, 5000, this);
        }
        private void ChangedHeight(object sender, EventArgs e)
        {
            CollapsiblePanel panel = (CollapsiblePanel)sender;
            if (panel.collapsed == true)
            {
                currentHeight -= (105 - 22);
            }
            else
            {
                currentHeight += (105 - 22);
            }
            RecalculateScrollBar();
        }
        private void RecalculateScrollBar()
        {
            if (currentHeight < (panel2.Height - 4))
            {
                vScrollBar1.Enabled = false;
                CollapsiblePanelContainer.Location = new Point(0, 0);
                offsetHeight = 0;
            }
            else
            {
                if (vScrollBar1.Enabled == false)
                    vScrollBar1.Enabled = true;
                vScrollBar1.Maximum = currentHeight - (panel2.Height-10);
                offsetHeight = Math.Min(currentHeight - (panel2.Height - 10), offsetHeight);
                CollapsiblePanelContainer.Location = new Point(0,-offsetHeight);
                vScrollBar1.Value = offsetHeight;
            }
        }
        private void timer1s_Tick(object sender, EventArgs e)
        {
            if (!paused)
            {
                foreach (var i in curPanelsByIP)
                {
                    Ping pingInterface = new Ping();
                    pingInfoNeed info = new pingInfoNeed();
                    info.tabPageCont = this;
                    info.destIP = i.Key;
                    info.timeSent = DateTime.Now;
                    pingInterface.PingCompleted += new PingCompletedEventHandler(RecieverPingAnswers);
                    pingInterface.SendAsync(i.Key, 5000, info);
                }
            }
        }
        public static void RecieverPingAnswers(object sender, PingCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                return;
            }
            pingInfoNeed info = (pingInfoNeed)e.UserState;
            if (e.Reply.Status == IPStatus.Success)
            {
                if(info.tabPageCont.curPanelsByIP.ContainsKey(info.destIP))
                {
                    info.tabPageCont.curPanelsByIP[info.destIP].SetValue(info.timeSent,(int)e.Reply.RoundtripTime);
                }
            }
            else
            {
                if (info.tabPageCont.curPanelsByIP.ContainsKey(info.destIP))
                {
                    info.tabPageCont.curPanelsByIP[info.destIP].SetValue(info.timeSent, -2);
                }
            }
        }
        public void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            newPath = null;
            oldPath = null;
            hostAddress = "";
            foreach (var i in curPanelsByIP.Values)
            {
                CollapsiblePanelContainer.Controls.Remove(i);
            }
            curPanelsByIP.Clear();
            curPanelsByPosition.Clear();
            timer10s.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer10s.Enabled = false;
            paused = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            offsetHeight = vScrollBar1.Value;
            CollapsiblePanelContainer.Location = new Point(0, -offsetHeight);
        }
        public void CreateSaveInfo(out SaveInfoPath info)
        {
            info = new SaveInfoPath();
            info.hostAddress = hostAddress;
            info.time = DateTime.Now;
            if (curPanelsByIP.Count == 0)
            {
                return;
            }
            info.ips = new SaveInfoIP[curPanelsByIP.Count];
            int j = 0;
            for (int i = 0; i < oldPath.Count; i++)
            {
                if (oldPath[i] != IPAddress.None)
                {
                    info.ips[j] = new SaveInfoIP();
                    info.ips[j].hop = i;
                    info.ips[j].IPAddress = oldPath[i].ToString();
                    info.ips[j].min = curPanelsByIP[oldPath[i]].GetData()[0];
                    info.ips[j].max = curPanelsByIP[oldPath[i]].GetData()[1];
                    info.ips[j].avg = curPanelsByIP[oldPath[i]].GetData()[2];
                    j++;
                }
            }
        }
    }
}
