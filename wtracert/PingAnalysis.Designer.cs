namespace kursach
{
    partial class PingAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.hideButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.fillingPanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.firstPage = new System.Windows.Forms.TabPage();
            this.newPage = new System.Windows.Forms.TabPage();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.networkUsageGraph = new System.Windows.Forms.Panel();
            this.graphLeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.fillingPanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.graphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_1s
            // 
            this.timer_1s.Enabled = true;
            this.timer_1s.Interval = 1000;
            this.timer_1s.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.hideButton);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 60);
            this.headerPanel.TabIndex = 2;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerMouseUp);
            // 
            // hideButton
            // 
            this.hideButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hideButton.Location = new System.Drawing.Point(708, 10);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(40, 40);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "_";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.HideButtonClick);
            // 
            // headerLabel
            // 
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(722, 58);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "WTracert";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerMouseDown);
            this.headerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerMouseMove);
            this.headerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerMouseUp);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Location = new System.Drawing.Point(755, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // fillingPanel
            // 
            this.fillingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fillingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fillingPanel.Controls.Add(this.tabControl);
            this.fillingPanel.Controls.Add(this.graphPanel);
            this.fillingPanel.Controls.Add(this.rightPanel);
            this.fillingPanel.Controls.Add(this.leftPanel);
            this.fillingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillingPanel.Location = new System.Drawing.Point(0, 60);
            this.fillingPanel.Name = "fillingPanel";
            this.fillingPanel.Size = new System.Drawing.Size(800, 440);
            this.fillingPanel.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.firstPage);
            this.tabControl.Controls.Add(this.newPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 9F);
            this.tabControl.ItemSize = new System.Drawing.Size(30, 22);
            this.tabControl.Location = new System.Drawing.Point(70, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(638, 338);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // firstPage
            // 
            this.firstPage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPage.Location = new System.Drawing.Point(4, 26);
            this.firstPage.Name = "firstPage";
            this.firstPage.Padding = new System.Windows.Forms.Padding(3);
            this.firstPage.Size = new System.Drawing.Size(630, 308);
            this.firstPage.TabIndex = 0;
            this.firstPage.Text = "Выберите сайт   ";
            this.firstPage.UseVisualStyleBackColor = true;
            // 
            // newPage
            // 
            this.newPage.Location = new System.Drawing.Point(4, 26);
            this.newPage.Name = "newPage";
            this.newPage.Padding = new System.Windows.Forms.Padding(3);
            this.newPage.Size = new System.Drawing.Size(630, 308);
            this.newPage.TabIndex = 1;
            this.newPage.Text = "+";
            this.newPage.UseVisualStyleBackColor = true;
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.networkUsageGraph);
            this.graphPanel.Controls.Add(this.graphLeftPanel);
            this.graphPanel.Controls.Add(this.label1);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.graphPanel.Location = new System.Drawing.Point(70, 0);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(638, 100);
            this.graphPanel.TabIndex = 0;
            // 
            // networkUsageGraph
            // 
            this.networkUsageGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.networkUsageGraph.Location = new System.Drawing.Point(0, 15);
            this.networkUsageGraph.Name = "networkUsageGraph";
            this.networkUsageGraph.Size = new System.Drawing.Size(638, 85);
            this.networkUsageGraph.TabIndex = 1;
            // 
            // graphLeftPanel
            // 
            this.graphLeftPanel.Location = new System.Drawing.Point(614, 15);
            this.graphLeftPanel.Name = "graphLeftPanel";
            this.graphLeftPanel.Size = new System.Drawing.Size(24, 85);
            this.graphLeftPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая нагрузка на сеть";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(708, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(90, 438);
            this.rightPanel.TabIndex = 3;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(70, 438);
            this.leftPanel.TabIndex = 2;
            // 
            // PingAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.fillingPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PingAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingAnalysis";
            this.Load += new System.EventHandler(this.PingAnalysis_Load);
            this.headerPanel.ResumeLayout(false);
            this.fillingPanel.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.graphPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel fillingPanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel networkUsageGraph;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel graphLeftPanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage firstPage;
        private TabPageContainer tabPageContainer1;
        private System.Windows.Forms.TabPage newPage;
        private System.Windows.Forms.Button hideButton;
    }
}