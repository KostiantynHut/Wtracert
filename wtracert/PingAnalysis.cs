using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace kursach
{
    public partial class PingAnalysis : Form
    {
        NetworkInterface curNIC;
        long lastPacketsSentRecieved;
        long maxPackets = 1024;
        Graph panel;

        bool m_isDragging = false;
        Point m_oldMouseAbsPos;

        public PingAnalysis(NetworkInterface nic)
        {
            InitializeComponent();
            curNIC = nic;
            headerLabel.Text = nic.Name;
            this.tabPageContainer1 = new TabPageContainer(firstPage);
            this.tabPageContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageContainer1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageContainer1.Location = new System.Drawing.Point(3, 3);
            this.tabPageContainer1.Name = "tabPageContainer1";
            this.tabPageContainer1.Size = new System.Drawing.Size(624, 302);
            this.tabPageContainer1.TabIndex = 0;
            this.firstPage.Controls.Add(this.tabPageContainer1);
        }
        private void PingAnalysis_Load(object sender, EventArgs e)
        {
            panel = new Graph();
            lastPacketsSentRecieved = (curNIC.GetIPv4Statistics().BytesReceived + curNIC.GetIPv4Statistics().BytesSent);
            panel.SetHighLabelText(mainForm.GetInternetSpeedString(maxPackets), (int)maxPackets);
            panel.SetHighMediumLabelText(mainForm.GetInternetSpeedString(maxPackets * 2 / 3), (int)maxPackets * 2 / 3);
            panel.SetLowMediumLabelText(mainForm.GetInternetSpeedString(maxPackets / 3), (int)maxPackets / 3);
            panel.SetLowLabelText(mainForm.GetInternetSpeedString(0), 0);
            panel.SetGraphTimer(timer_1s);
            networkUsageGraph.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            long curPackets = (curNIC.GetIPv4Statistics().BytesReceived + curNIC.GetIPv4Statistics().BytesSent) - lastPacketsSentRecieved;
            if (curPackets > maxPackets)
            {
                maxPackets = curPackets;
                panel.SetHighLabelText(mainForm.GetInternetSpeedString(maxPackets), (int)maxPackets);
                panel.SetHighMediumLabelText(mainForm.GetInternetSpeedString(maxPackets * 2 / 3), (int)maxPackets * 2 / 3);
                panel.SetLowMediumLabelText(mainForm.GetInternetSpeedString(maxPackets / 3), (int)maxPackets / 3);
                panel.SetLowLabelText(mainForm.GetInternetSpeedString(0), 0);
            }
            Random rnd = new Random();
            DateTime tempTime = DateTime.Now;
            tempTime = tempTime.AddMilliseconds(-tempTime.Millisecond);
            tempTime = tempTime.AddSeconds(-2.0f);
            panel.SetValue(tempTime, (int)curPackets);
            lastPacketsSentRecieved = (curNIC.GetIPv4Statistics().BytesReceived + curNIC.GetIPv4Statistics().BytesSent);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(128, 128, 255)), e.Bounds);
            
            if (e.Index != tabControl.TabPages.Count - 1)
            {
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left, e.Bounds.Top);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(192, 192, 192)), e.Bounds.Right - e.Bounds.Height - 2, 3, e.Bounds.Height - 2, e.Bounds.Height - 2);
                e.Graphics.DrawString("X", e.Font, Brushes.Black, e.Bounds.Right - e.Bounds.Height - 2, 3);
            }
            else
            {
                SizeF temp = e.Graphics.MeasureString(this.tabControl.TabPages[e.Index].Text, e.Font);
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + ((e.Bounds.Width - temp.Width) / 2), e.Bounds.Top);
            }
        }
        private void closeTabClick(int index)
        {
            tabControl.TabPages.RemoveAt(index);
        }
        private void addButtonClick()
        {
            TabPage lastTabPage = tabControl.TabPages[tabControl.TabPages.Count - 1];
            TabPage newTabPage = new TabPage("   ");
            lastTabPage.Text = "Выберите сайт   ";
            TabPageContainer tabContainer = new TabPageContainer(lastTabPage);
            lastTabPage.Controls.Add(tabContainer);
            tabContainer.Dock = DockStyle.Fill;
            tabControl.TabPages.Add(newTabPage);
        }
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);
                if (r.Contains(e.Location))
                {
                    if (i == tabControl.TabPages.Count - 1)
                    {
                        addButtonClick();
                        return;
                    }
                }
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - r.Height -2, r.Top + 3, r.Height, r.Height);
                if (closeButton.Contains(e.Location))
                {
                    {
                        closeTabClick(i);
                    }
                }
            }
        }

        private void HideButtonClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void headerMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m_oldMouseAbsPos = new Point(e.X, e.Y);
                m_isDragging = true;
            }

        }

        private void headerMouseMove(object sender, MouseEventArgs e)
        {
            if (m_isDragging)
            {
                this.Location = new Point(this.Location.X + (e.X - m_oldMouseAbsPos.X), this.Location.Y + (e.Y - m_oldMouseAbsPos.Y));
            }
        }

        private void headerMouseUp(object sender, MouseEventArgs e)
        {
            m_isDragging = false;
        }
    }
}
