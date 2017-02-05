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
    public partial class mainForm : Form
    {
        // network
        Dictionary<int, NetworkInterface> m_networkInterfaces;
        int m_curInterface;
        long m_lastBytesSent;
        long m_lastBytesRecieved;

        //dragging
        bool m_isDragging = false;
        Point m_oldMouseAbsPos;

        // Color consts
        protected enum COLOR_TYPE{RED,YELLOW,GREEN};
        Color strongRed = Color.FromArgb(192, 0, 0);
        Color strongGreen = Color.FromArgb(0, 192, 0);
        Color strongYellow = Color.FromArgb(192, 192, 0);
        Color lightRed = Color.FromArgb(255, 192, 192);
        Color lightGreen = Color.FromArgb(192, 255, 192);
        Color lightYellow = Color.FromArgb(255,255,192);

        public mainForm()
        {
            m_networkInterfaces = new Dictionary<int, NetworkInterface>();
            m_curInterface = -1;
            InitializeComponent();
            m_isDragging = false;
        }
        ~mainForm()
        {
            networkConnectionTimer.Stop();
        }
        protected void SetLabelColor(Label lbl, COLOR_TYPE colorType)
        {
            if (colorType == COLOR_TYPE.RED)
            {
                lbl.ForeColor = strongRed;
                lbl.BackColor = lightRed;
            }
            else if (colorType == COLOR_TYPE.GREEN)
            {
                lbl.ForeColor = strongGreen;
                lbl.BackColor = lightGreen;
            }
            else if (colorType == COLOR_TYPE.YELLOW)
            {
                lbl.ForeColor = strongYellow;
                lbl.BackColor = lightYellow;
            }

        }
        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
        private void HideButtonClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool isNetInterfaceValid(NetworkInterface netInt)
        {

            bool isNotLoopback = netInt.NetworkInterfaceType != NetworkInterfaceType.Loopback;
            bool isNotTunnel = netInt.NetworkInterfaceType != NetworkInterfaceType.Tunnel;
            return isNotLoopback && isNotTunnel;
        }
        public static string GetInternetSpeedString(long speed)
        {
            if (speed < 1024)
            {
                return string.Format("{0}B/s",speed);
            }
            if (speed < 1024 * 1024)
            {
                float speedInKiB = (1.0f*speed)/1024;
                return string.Format("{0:F2}KiB/s", speedInKiB);
            }
            if (speed < (((long)1024) * 1024 * 1024))
            {
                float speedInMiB = (1.0f * speed) / (1024 * 1024);
                return string.Format("{0:F2}MiB/s",speedInMiB);
            }
            float speedInGiB = (1.0f * speed) / (((long)1024) * 1024 * 1024);
            return string.Format("{0:F2}GiB/s", speedInGiB);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chooseConnetionCmbBox.Items.Clear();
            var nicArr = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nicArr)
            {
                if (isNetInterfaceValid(nic))
                {
                    int id = chooseConnetionCmbBox.Items.Add(nic.Name);
                    m_networkInterfaces.Add(id, nic);
                }
            }
            foreach (var pair in m_networkInterfaces)
            {
                chooseConnetionCmbBox.SelectedIndex = pair.Key;
                if (pair.Value.OperationalStatus == OperationalStatus.Up)
                {
                    break;
                }
            }
        }
        
        private void chooseConnetionCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_curInterface = chooseConnetionCmbBox.SelectedIndex;
            var nic = m_networkInterfaces[m_curInterface];
            networkConnectionTypeInfo.Text = nic.NetworkInterfaceType.ToString();
           
            if (nic.Speed > 0)
            {
                SetLabelColor(networkConnectionMaxSpeedInfo,COLOR_TYPE.GREEN);
                networkConnectionMaxSpeedInfo.Text = GetInternetSpeedString(nic.Speed);
            }
            else
            {
                SetLabelColor(networkConnectionMaxSpeedInfo,COLOR_TYPE.RED);
                networkConnectionMaxSpeedInfo.Text = "None";
            }
            if (nic.OperationalStatus == OperationalStatus.Down)
            {
                SetLabelColor(networkConnectionStateInfo,COLOR_TYPE.RED);
            }
            else if(nic.OperationalStatus == OperationalStatus.Up)
            {
                SetLabelColor(networkConnectionStateInfo,COLOR_TYPE.GREEN);
            }
            else
            {
                SetLabelColor(networkConnectionStateInfo,COLOR_TYPE.YELLOW);
            }
            networkConnectionStateInfo.Text = nic.OperationalStatus.ToString();
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                networkConnectionTimer.Start();
                var ipStat = nic.GetIPv4Statistics();
                m_lastBytesSent = ipStat.BytesSent;
                m_lastBytesRecieved = ipStat.BytesReceived;
                SetLabelColor(networkConnectionSpeedInfo, COLOR_TYPE.GREEN);
                networkConnectionSpeedInfo.Text = "Computing...";
            }
            else
            {
                SetLabelColor(networkConnectionSpeedInfo, COLOR_TYPE.RED);
                networkConnectionTimer.Stop();
                networkConnectionSpeedInfo.Text = "Not Connected";
            }
            networkConnectionMacAddress.Text = nic.GetPhysicalAddress().ToString();
            networkConnectionIP.Text = "";
            networkConnectionGateway.Text = "";
            networkConnectionMask.Text = "";
            networkConnectionDNSServer.Text = "";
            if (nic.OperationalStatus == OperationalStatus.Up)
            {
                var ipProp = nic.GetIPProperties();
                if (ipProp.UnicastAddresses.Count > 0)
                {
                    networkConnectionIP.Text = ipProp.UnicastAddresses[ipProp.UnicastAddresses.Count - 1].Address.ToString();
                    networkConnectionMask.Text = ipProp.UnicastAddresses[ipProp.UnicastAddresses.Count -1].IPv4Mask.ToString();
                }
                if (ipProp.DnsAddresses.Count > 0)
                {
                    networkConnectionDNSServer.Text = ipProp.DnsAddresses[ipProp.DnsAddresses.Count - 1].ToString();
                }
                if (ipProp.GatewayAddresses.Count > 0)
                {
                    networkConnectionGateway.Text = ipProp.GatewayAddresses[ipProp.GatewayAddresses.Count - 1].Address.ToString();
                }
            }    
        }
        private void networkConnectionTimer_Tick(object sender, EventArgs e)
        {
            var ipStat = m_networkInterfaces[m_curInterface].GetIPv4Statistics();
            if (m_networkInterfaces[m_curInterface].OperationalStatus == OperationalStatus.Down)
            {
                networkConnectionStateInfo.BackColor = lightRed;
                networkConnectionStateInfo.ForeColor = strongRed;
            }
            else if (m_networkInterfaces[m_curInterface].OperationalStatus == OperationalStatus.Up)
            {
                networkConnectionStateInfo.BackColor = lightGreen;
                networkConnectionStateInfo.ForeColor = strongGreen;
            }
            else
            {
                networkConnectionStateInfo.BackColor = Color.FromArgb(255, 255, 192);
                networkConnectionStateInfo.ForeColor = Color.FromArgb(192, 192, 0);
            }
            networkConnectionStateInfo.Text = m_networkInterfaces[m_curInterface].OperationalStatus.ToString();
            long newLastBytesSent = ipStat.BytesSent;
            long newLastBytesRecieved = ipStat.BytesReceived;
            long bytesSent = newLastBytesSent - m_lastBytesSent;
            long bytesRecieved = newLastBytesRecieved - m_lastBytesRecieved;
            if (m_networkInterfaces[m_curInterface].OperationalStatus == OperationalStatus.Up)
            {
                if (bytesSent + bytesRecieved > 0)
                {
                    networkConnectionSpeedInfo.ForeColor = Color.FromArgb(0, 192, 0);
                    networkConnectionSpeedInfo.BackColor = Color.FromArgb(192, 255, 192);
                    networkConnectionSpeedInfo.Text = GetInternetSpeedString(bytesSent + bytesRecieved);
                }
                else
                {
                    networkConnectionSpeedInfo.ForeColor = Color.FromArgb(192, 192, 0);
                    networkConnectionSpeedInfo.BackColor = Color.FromArgb(255, 255, 192);
                    networkConnectionSpeedInfo.Text = GetInternetSpeedString(bytesSent + bytesRecieved);
                }
            }
            else 
            {
                networkConnectionSpeedInfo.ForeColor = Color.FromArgb(192, 0, 0);
                networkConnectionSpeedInfo.BackColor = Color.FromArgb(255, 192, 192); 
                networkConnectionSpeedInfo.Text = "Not Connected";
            }
            m_lastBytesSent = newLastBytesSent;
            m_lastBytesRecieved = newLastBytesRecieved;
            if (NetworkInterface.GetIsNetworkAvailable() == false)
            {
                InternetConnectionLabel.ForeColor = Color.Red;
                dnsServerPing.Text = "No Connection";
                dnsServerPing.ForeColor = Color.FromArgb(192, 0, 0);
                googlePing.Text = "No Connection";
                googlePing.ForeColor = Color.FromArgb(192, 0, 0);
            }
            else
            {
                InternetConnectionLabel.ForeColor = Color.Green;
                
                Ping pingInterfaceDns = new Ping();
                Ping pingInterfaceG = new Ping();
                pingInterfaceDns.PingCompleted += new PingCompletedEventHandler(DnsCompletedCallback);
                pingInterfaceG.PingCompleted += new PingCompletedEventHandler(GCompletedCallback);
                pingInterfaceDns.SendAsync(m_networkInterfaces[m_curInterface].GetIPProperties().DnsAddresses[m_networkInterfaces[m_curInterface].GetIPProperties().DnsAddresses.Count - 1].ToString(), 5, dnsServerPing);
                pingInterfaceG.SendAsync("google.com",5, googlePing);
            }
        }
        private static void DnsCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            Label dnsServerPing = (Label)e.UserState;
            if (e.Reply.Status == IPStatus.Success)
            {
                dnsServerPing.ForeColor = Color.FromArgb(0, 192, 0);
                dnsServerPing.Text = e.Reply.RoundtripTime.ToString() + "ms";
            }
            else
            {
                dnsServerPing.Text = "No Ping";
                dnsServerPing.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }
        public static void GCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            Label googlePing = (Label)e.UserState;
            if (e.Error != null)
            {
                googlePing.Text = "No ping";
                googlePing.ForeColor = Color.FromArgb(192, 0, 0);
                return;
            }
            if (e.Reply.Status == IPStatus.Success)
            {
                googlePing.ForeColor = Color.FromArgb(0, 192, 0);
                googlePing.Text = e.Reply.RoundtripTime.ToString() + "ms";
            }
            else
            {
                googlePing.Text = "No ping";
                googlePing.ForeColor = Color.FromArgb(192, 0, 0);
            }
        }
        private void TraceButtonClick(object sender, EventArgs e)
        {
            PingAnalysis form = new PingAnalysis(m_networkInterfaces[m_curInterface]);
            this.Hide();
            form.ShowDialog();
            this.Show();
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
