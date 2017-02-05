namespace kursach
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.TraceButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.googlePing = new System.Windows.Forms.Label();
            this.labelGlobalPing = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dnsServerPing = new System.Windows.Forms.Label();
            this.labelDNSPing = new System.Windows.Forms.Label();
            this.InternetConnectionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGateway = new System.Windows.Forms.Label();
            this.networkConnectionGateway = new System.Windows.Forms.TextBox();
            this.networkConnectionDNSServer = new System.Windows.Forms.TextBox();
            this.labelDNS = new System.Windows.Forms.Label();
            this.networkConnectionMask = new System.Windows.Forms.TextBox();
            this.networkConnectionIP = new System.Windows.Forms.TextBox();
            this.networkConnectionMacAddress = new System.Windows.Forms.TextBox();
            this.labelMask = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelMAC = new System.Windows.Forms.Label();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.currentSpeedPanel = new System.Windows.Forms.Panel();
            this.networkConnectionSpeedInfo = new System.Windows.Forms.Label();
            this.networkConnectionSpeedLabel = new System.Windows.Forms.Label();
            this.currentStatusPanel = new System.Windows.Forms.Panel();
            this.networkConnectionStateInfo = new System.Windows.Forms.Label();
            this.networkConnectionStateLabel = new System.Windows.Forms.Label();
            this.maxNetInterfaceSpeedPanel = new System.Windows.Forms.Panel();
            this.networkConnectionMaxSpeedInfo = new System.Windows.Forms.Label();
            this.networkConnectionMaxSpeedLabel = new System.Windows.Forms.Label();
            this.networkInterfaceTypePanel = new System.Windows.Forms.Panel();
            this.networkConnectionTypeInfo = new System.Windows.Forms.Label();
            this.networkConnectionTypeLabel = new System.Windows.Forms.Label();
            this.chooseConnetionPanel = new System.Windows.Forms.Panel();
            this.chooseConnetionCmbBox = new System.Windows.Forms.ComboBox();
            this.chooseUsedConnectionLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.networkConnectionTimer = new System.Windows.Forms.Timer(this.components);
            this.windowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.connectionPanel.SuspendLayout();
            this.currentSpeedPanel.SuspendLayout();
            this.currentStatusPanel.SuspendLayout();
            this.maxNetInterfaceSpeedPanel.SuspendLayout();
            this.networkInterfaceTypePanel.SuspendLayout();
            this.chooseConnetionPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.windowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windowPanel.Controls.Add(this.TraceButton);
            this.windowPanel.Controls.Add(this.panel1);
            this.windowPanel.Controls.Add(this.connectionPanel);
            this.windowPanel.Controls.Add(this.headerPanel);
            this.windowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPanel.Location = new System.Drawing.Point(0, 0);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(800, 500);
            this.windowPanel.TabIndex = 0;
            // 
            // TraceButton
            // 
            this.TraceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TraceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TraceButton.Location = new System.Drawing.Point(13, 383);
            this.TraceButton.Name = "TraceButton";
            this.TraceButton.Size = new System.Drawing.Size(774, 91);
            this.TraceButton.TabIndex = 5;
            this.TraceButton.Text = "Трассировка маршрута";
            this.TraceButton.UseVisualStyleBackColor = false;
            this.TraceButton.Click += new System.EventHandler(this.TraceButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 146);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.InternetConnectionLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(398, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 146);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.googlePing);
            this.panel5.Controls.Add(this.labelGlobalPing);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(197, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 122);
            this.panel5.TabIndex = 2;
            // 
            // googlePing
            // 
            this.googlePing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.googlePing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.googlePing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.googlePing.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.googlePing.Location = new System.Drawing.Point(0, 28);
            this.googlePing.Name = "googlePing";
            this.googlePing.Size = new System.Drawing.Size(195, 90);
            this.googlePing.TabIndex = 1;
            this.googlePing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGlobalPing
            // 
            this.labelGlobalPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGlobalPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGlobalPing.Location = new System.Drawing.Point(0, 0);
            this.labelGlobalPing.Name = "labelGlobalPing";
            this.labelGlobalPing.Size = new System.Drawing.Size(195, 28);
            this.labelGlobalPing.TabIndex = 0;
            this.labelGlobalPing.Text = "Пинг до google.com";
            this.labelGlobalPing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dnsServerPing);
            this.panel4.Controls.Add(this.labelDNSPing);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 122);
            this.panel4.TabIndex = 1;
            // 
            // dnsServerPing
            // 
            this.dnsServerPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dnsServerPing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dnsServerPing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dnsServerPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dnsServerPing.Location = new System.Drawing.Point(0, 28);
            this.dnsServerPing.Name = "dnsServerPing";
            this.dnsServerPing.Size = new System.Drawing.Size(193, 90);
            this.dnsServerPing.TabIndex = 1;
            this.dnsServerPing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDNSPing
            // 
            this.labelDNSPing.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDNSPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDNSPing.Location = new System.Drawing.Point(0, 0);
            this.labelDNSPing.Name = "labelDNSPing";
            this.labelDNSPing.Size = new System.Drawing.Size(193, 28);
            this.labelDNSPing.TabIndex = 0;
            this.labelDNSPing.Text = "Пинг до DNS-сервера";
            this.labelDNSPing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // InternetConnectionLabel
            // 
            this.InternetConnectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InternetConnectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InternetConnectionLabel.Location = new System.Drawing.Point(0, 0);
            this.InternetConnectionLabel.Name = "InternetConnectionLabel";
            this.InternetConnectionLabel.Size = new System.Drawing.Size(396, 20);
            this.InternetConnectionLabel.TabIndex = 0;
            this.InternetConnectionLabel.Text = "Подключение к интернету";
            this.InternetConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelGateway);
            this.panel2.Controls.Add(this.networkConnectionGateway);
            this.panel2.Controls.Add(this.networkConnectionDNSServer);
            this.panel2.Controls.Add(this.labelDNS);
            this.panel2.Controls.Add(this.networkConnectionMask);
            this.panel2.Controls.Add(this.networkConnectionIP);
            this.panel2.Controls.Add(this.networkConnectionMacAddress);
            this.panel2.Controls.Add(this.labelMask);
            this.panel2.Controls.Add(this.labelIP);
            this.panel2.Controls.Add(this.labelMAC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 146);
            this.panel2.TabIndex = 0;
            // 
            // labelGateway
            // 
            this.labelGateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelGateway.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGateway.Location = new System.Drawing.Point(1, 91);
            this.labelGateway.Name = "labelGateway";
            this.labelGateway.Size = new System.Drawing.Size(196, 20);
            this.labelGateway.TabIndex = 7;
            this.labelGateway.Text = "Адрес шлюза сети";
            // 
            // networkConnectionGateway
            // 
            this.networkConnectionGateway.Enabled = false;
            this.networkConnectionGateway.Location = new System.Drawing.Point(197, 92);
            this.networkConnectionGateway.Name = "networkConnectionGateway";
            this.networkConnectionGateway.Size = new System.Drawing.Size(193, 20);
            this.networkConnectionGateway.TabIndex = 8;
            // 
            // networkConnectionDNSServer
            // 
            this.networkConnectionDNSServer.Enabled = false;
            this.networkConnectionDNSServer.Location = new System.Drawing.Point(197, 72);
            this.networkConnectionDNSServer.Name = "networkConnectionDNSServer";
            this.networkConnectionDNSServer.Size = new System.Drawing.Size(193, 20);
            this.networkConnectionDNSServer.TabIndex = 7;
            // 
            // labelDNS
            // 
            this.labelDNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDNS.Location = new System.Drawing.Point(1, 71);
            this.labelDNS.Name = "labelDNS";
            this.labelDNS.Size = new System.Drawing.Size(196, 20);
            this.labelDNS.TabIndex = 6;
            this.labelDNS.Text = "Адрес DNS-сервера";
            // 
            // networkConnectionMask
            // 
            this.networkConnectionMask.Enabled = false;
            this.networkConnectionMask.Location = new System.Drawing.Point(197, 42);
            this.networkConnectionMask.Name = "networkConnectionMask";
            this.networkConnectionMask.Size = new System.Drawing.Size(193, 20);
            this.networkConnectionMask.TabIndex = 5;
            // 
            // networkConnectionIP
            // 
            this.networkConnectionIP.Enabled = false;
            this.networkConnectionIP.Location = new System.Drawing.Point(197, 22);
            this.networkConnectionIP.Name = "networkConnectionIP";
            this.networkConnectionIP.Size = new System.Drawing.Size(193, 20);
            this.networkConnectionIP.TabIndex = 4;
            // 
            // networkConnectionMacAddress
            // 
            this.networkConnectionMacAddress.Enabled = false;
            this.networkConnectionMacAddress.Location = new System.Drawing.Point(197, 2);
            this.networkConnectionMacAddress.Name = "networkConnectionMacAddress";
            this.networkConnectionMacAddress.Size = new System.Drawing.Size(193, 20);
            this.networkConnectionMacAddress.TabIndex = 3;
            // 
            // labelMask
            // 
            this.labelMask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMask.Location = new System.Drawing.Point(1, 41);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(196, 20);
            this.labelMask.TabIndex = 2;
            this.labelMask.Text = "Маска сети";
            // 
            // labelIP
            // 
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIP.Location = new System.Drawing.Point(1, 21);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(196, 20);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Сетевой адрес (IP)";
            // 
            // labelMAC
            // 
            this.labelMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMAC.Location = new System.Drawing.Point(1, 1);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(196, 20);
            this.labelMAC.TabIndex = 0;
            this.labelMAC.Text = "Физический адрес (MAC)";
            // 
            // connectionPanel
            // 
            this.connectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.connectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectionPanel.Controls.Add(this.currentSpeedPanel);
            this.connectionPanel.Controls.Add(this.currentStatusPanel);
            this.connectionPanel.Controls.Add(this.maxNetInterfaceSpeedPanel);
            this.connectionPanel.Controls.Add(this.networkInterfaceTypePanel);
            this.connectionPanel.Controls.Add(this.chooseConnetionPanel);
            this.connectionPanel.Controls.Add(this.chooseUsedConnectionLabel);
            this.connectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionPanel.ForeColor = System.Drawing.Color.White;
            this.connectionPanel.Location = new System.Drawing.Point(0, 60);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(798, 132);
            this.connectionPanel.TabIndex = 3;
            // 
            // currentSpeedPanel
            // 
            this.currentSpeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentSpeedPanel.Controls.Add(this.networkConnectionSpeedInfo);
            this.currentSpeedPanel.Controls.Add(this.networkConnectionSpeedLabel);
            this.currentSpeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentSpeedPanel.Location = new System.Drawing.Point(596, 54);
            this.currentSpeedPanel.Name = "currentSpeedPanel";
            this.currentSpeedPanel.Size = new System.Drawing.Size(200, 76);
            this.currentSpeedPanel.TabIndex = 5;
            // 
            // networkConnectionSpeedInfo
            // 
            this.networkConnectionSpeedInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.networkConnectionSpeedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkConnectionSpeedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionSpeedInfo.ForeColor = System.Drawing.Color.LimeGreen;
            this.networkConnectionSpeedInfo.Location = new System.Drawing.Point(0, 20);
            this.networkConnectionSpeedInfo.Name = "networkConnectionSpeedInfo";
            this.networkConnectionSpeedInfo.Size = new System.Drawing.Size(196, 52);
            this.networkConnectionSpeedInfo.TabIndex = 1;
            this.networkConnectionSpeedInfo.Text = "#NETWORKCONNECTIONSPEED";
            this.networkConnectionSpeedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkConnectionSpeedLabel
            // 
            this.networkConnectionSpeedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.networkConnectionSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkConnectionSpeedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkConnectionSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionSpeedLabel.Location = new System.Drawing.Point(0, 0);
            this.networkConnectionSpeedLabel.Name = "networkConnectionSpeedLabel";
            this.networkConnectionSpeedLabel.Size = new System.Drawing.Size(196, 20);
            this.networkConnectionSpeedLabel.TabIndex = 0;
            this.networkConnectionSpeedLabel.Text = "Текущее использование соединения";
            this.networkConnectionSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentStatusPanel
            // 
            this.currentStatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentStatusPanel.Controls.Add(this.networkConnectionStateInfo);
            this.currentStatusPanel.Controls.Add(this.networkConnectionStateLabel);
            this.currentStatusPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentStatusPanel.Location = new System.Drawing.Point(397, 54);
            this.currentStatusPanel.Name = "currentStatusPanel";
            this.currentStatusPanel.Size = new System.Drawing.Size(199, 76);
            this.currentStatusPanel.TabIndex = 4;
            // 
            // networkConnectionStateInfo
            // 
            this.networkConnectionStateInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.networkConnectionStateInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkConnectionStateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionStateInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.networkConnectionStateInfo.Location = new System.Drawing.Point(0, 20);
            this.networkConnectionStateInfo.Name = "networkConnectionStateInfo";
            this.networkConnectionStateInfo.Size = new System.Drawing.Size(195, 52);
            this.networkConnectionStateInfo.TabIndex = 1;
            this.networkConnectionStateInfo.Text = "#NETWORKCONNECTIONSTATE";
            this.networkConnectionStateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkConnectionStateLabel
            // 
            this.networkConnectionStateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.networkConnectionStateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkConnectionStateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkConnectionStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionStateLabel.Location = new System.Drawing.Point(0, 0);
            this.networkConnectionStateLabel.Name = "networkConnectionStateLabel";
            this.networkConnectionStateLabel.Size = new System.Drawing.Size(195, 20);
            this.networkConnectionStateLabel.TabIndex = 0;
            this.networkConnectionStateLabel.Text = "Состояние соединения";
            this.networkConnectionStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxNetInterfaceSpeedPanel
            // 
            this.maxNetInterfaceSpeedPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maxNetInterfaceSpeedPanel.Controls.Add(this.networkConnectionMaxSpeedInfo);
            this.maxNetInterfaceSpeedPanel.Controls.Add(this.networkConnectionMaxSpeedLabel);
            this.maxNetInterfaceSpeedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxNetInterfaceSpeedPanel.Location = new System.Drawing.Point(198, 54);
            this.maxNetInterfaceSpeedPanel.Name = "maxNetInterfaceSpeedPanel";
            this.maxNetInterfaceSpeedPanel.Size = new System.Drawing.Size(199, 76);
            this.maxNetInterfaceSpeedPanel.TabIndex = 3;
            // 
            // networkConnectionMaxSpeedInfo
            // 
            this.networkConnectionMaxSpeedInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.networkConnectionMaxSpeedInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkConnectionMaxSpeedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionMaxSpeedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.networkConnectionMaxSpeedInfo.Location = new System.Drawing.Point(0, 20);
            this.networkConnectionMaxSpeedInfo.Name = "networkConnectionMaxSpeedInfo";
            this.networkConnectionMaxSpeedInfo.Size = new System.Drawing.Size(195, 52);
            this.networkConnectionMaxSpeedInfo.TabIndex = 1;
            this.networkConnectionMaxSpeedInfo.Text = "#NETWORKCONNECTIONMAXSPEED";
            this.networkConnectionMaxSpeedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkConnectionMaxSpeedLabel
            // 
            this.networkConnectionMaxSpeedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.networkConnectionMaxSpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkConnectionMaxSpeedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkConnectionMaxSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionMaxSpeedLabel.Location = new System.Drawing.Point(0, 0);
            this.networkConnectionMaxSpeedLabel.Name = "networkConnectionMaxSpeedLabel";
            this.networkConnectionMaxSpeedLabel.Size = new System.Drawing.Size(195, 20);
            this.networkConnectionMaxSpeedLabel.TabIndex = 0;
            this.networkConnectionMaxSpeedLabel.Text = "Максимальная скорость";
            this.networkConnectionMaxSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkInterfaceTypePanel
            // 
            this.networkInterfaceTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.networkInterfaceTypePanel.Controls.Add(this.networkConnectionTypeInfo);
            this.networkInterfaceTypePanel.Controls.Add(this.networkConnectionTypeLabel);
            this.networkInterfaceTypePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.networkInterfaceTypePanel.Location = new System.Drawing.Point(0, 54);
            this.networkInterfaceTypePanel.Name = "networkInterfaceTypePanel";
            this.networkInterfaceTypePanel.Size = new System.Drawing.Size(198, 76);
            this.networkInterfaceTypePanel.TabIndex = 2;
            // 
            // networkConnectionTypeInfo
            // 
            this.networkConnectionTypeInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.networkConnectionTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkConnectionTypeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionTypeInfo.ForeColor = System.Drawing.Color.Black;
            this.networkConnectionTypeInfo.Location = new System.Drawing.Point(0, 20);
            this.networkConnectionTypeInfo.Name = "networkConnectionTypeInfo";
            this.networkConnectionTypeInfo.Size = new System.Drawing.Size(194, 52);
            this.networkConnectionTypeInfo.TabIndex = 1;
            this.networkConnectionTypeInfo.Text = "#NETWORKCONNECTIONTYPE";
            this.networkConnectionTypeInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // networkConnectionTypeLabel
            // 
            this.networkConnectionTypeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.networkConnectionTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkConnectionTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.networkConnectionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.networkConnectionTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.networkConnectionTypeLabel.Name = "networkConnectionTypeLabel";
            this.networkConnectionTypeLabel.Size = new System.Drawing.Size(194, 20);
            this.networkConnectionTypeLabel.TabIndex = 0;
            this.networkConnectionTypeLabel.Text = "Тип cоединения";
            this.networkConnectionTypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chooseConnetionPanel
            // 
            this.chooseConnetionPanel.Controls.Add(this.chooseConnetionCmbBox);
            this.chooseConnetionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseConnetionPanel.Location = new System.Drawing.Point(0, 24);
            this.chooseConnetionPanel.Name = "chooseConnetionPanel";
            this.chooseConnetionPanel.Size = new System.Drawing.Size(796, 30);
            this.chooseConnetionPanel.TabIndex = 1;
            // 
            // chooseConnetionCmbBox
            // 
            this.chooseConnetionCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chooseConnetionCmbBox.FormattingEnabled = true;
            this.chooseConnetionCmbBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.chooseConnetionCmbBox.Location = new System.Drawing.Point(272, 3);
            this.chooseConnetionCmbBox.Name = "chooseConnetionCmbBox";
            this.chooseConnetionCmbBox.Size = new System.Drawing.Size(250, 21);
            this.chooseConnetionCmbBox.TabIndex = 0;
            this.chooseConnetionCmbBox.SelectedIndexChanged += new System.EventHandler(this.chooseConnetionCmbBox_SelectedIndexChanged);
            // 
            // chooseUsedConnectionLabel
            // 
            this.chooseUsedConnectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseUsedConnectionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseUsedConnectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.chooseUsedConnectionLabel.Location = new System.Drawing.Point(0, 0);
            this.chooseUsedConnectionLabel.Name = "chooseUsedConnectionLabel";
            this.chooseUsedConnectionLabel.Size = new System.Drawing.Size(796, 24);
            this.chooseUsedConnectionLabel.TabIndex = 0;
            this.chooseUsedConnectionLabel.Text = "Выберите используемое соединение";
            this.chooseUsedConnectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.MinimizeButton);
            this.headerPanel.Controls.Add(this.CloseButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(798, 60);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerMouseUp);
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLabel.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(195, 58);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "WTracert";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerMouseDown);
            this.headerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerMouseMove);
            this.headerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerMouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinimizeButton.Location = new System.Drawing.Point(707, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(40, 40);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.HideButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseButton.Location = new System.Drawing.Point(753, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // networkConnectionTimer
            // 
            this.networkConnectionTimer.Interval = 1000;
            this.networkConnectionTimer.Tick += new System.EventHandler(this.networkConnectionTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.windowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.windowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.connectionPanel.ResumeLayout(false);
            this.currentSpeedPanel.ResumeLayout(false);
            this.currentStatusPanel.ResumeLayout(false);
            this.maxNetInterfaceSpeedPanel.ResumeLayout(false);
            this.networkInterfaceTypePanel.ResumeLayout(false);
            this.chooseConnetionPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Panel chooseConnetionPanel;
        private System.Windows.Forms.ComboBox chooseConnetionCmbBox;
        private System.Windows.Forms.Label chooseUsedConnectionLabel;
        private System.Windows.Forms.Panel networkInterfaceTypePanel;
        private System.Windows.Forms.Panel currentSpeedPanel;
        private System.Windows.Forms.Panel currentStatusPanel;
        private System.Windows.Forms.Panel maxNetInterfaceSpeedPanel;
        private System.Windows.Forms.Label networkConnectionTypeLabel;
        private System.Windows.Forms.Label networkConnectionSpeedInfo;
        private System.Windows.Forms.Label networkConnectionSpeedLabel;
        private System.Windows.Forms.Label networkConnectionStateInfo;
        private System.Windows.Forms.Label networkConnectionStateLabel;
        private System.Windows.Forms.Label networkConnectionMaxSpeedInfo;
        private System.Windows.Forms.Label networkConnectionMaxSpeedLabel;
        private System.Windows.Forms.Label networkConnectionTypeInfo;
        private System.Windows.Forms.Timer networkConnectionTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.TextBox networkConnectionMask;
        private System.Windows.Forms.TextBox networkConnectionIP;
        private System.Windows.Forms.TextBox networkConnectionMacAddress;
        private System.Windows.Forms.Label labelGateway;
        private System.Windows.Forms.TextBox networkConnectionDNSServer;
        private System.Windows.Forms.Label labelDNS;
        private System.Windows.Forms.TextBox networkConnectionGateway;
        private System.Windows.Forms.Label InternetConnectionLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button TraceButton;
        private System.Windows.Forms.Label googlePing;
        private System.Windows.Forms.Label labelGlobalPing;
        private System.Windows.Forms.Label dnsServerPing;
        private System.Windows.Forms.Label labelDNSPing;
    }
}

