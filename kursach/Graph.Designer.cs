namespace kursach
{
    partial class Graph
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.HighLabel = new System.Windows.Forms.Label();
            this.HighMediumLabel = new System.Windows.Forms.Label();
            this.LowMediumLabel = new System.Windows.Forms.Label();
            this.LowLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TimelinePanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 85);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 64);
            this.panel2.TabIndex = 2;
            // 
            // LabelPanel
            // 
            this.LabelPanel.BackColor = System.Drawing.Color.Gray;
            this.LabelPanel.Controls.Add(this.HighLabel);
            this.LabelPanel.Controls.Add(this.HighMediumLabel);
            this.LabelPanel.Controls.Add(this.LowMediumLabel);
            this.LabelPanel.Controls.Add(this.LowLabel);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPanel.Location = new System.Drawing.Point(0, 0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(45, 64);
            this.LabelPanel.TabIndex = 1;
            // 
            // HighLabel
            // 
            this.HighLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HighLabel.BackColor = System.Drawing.Color.Silver;
            this.HighLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighLabel.Location = new System.Drawing.Point(0, 0);
            this.HighLabel.Name = "HighLabel";
            this.HighLabel.Size = new System.Drawing.Size(45, 16);
            this.HighLabel.TabIndex = 3;
            this.HighLabel.Text = "5000";
            this.HighLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HighMediumLabel
            // 
            this.HighMediumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HighMediumLabel.BackColor = System.Drawing.Color.Silver;
            this.HighMediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighMediumLabel.Location = new System.Drawing.Point(0, 16);
            this.HighMediumLabel.Name = "HighMediumLabel";
            this.HighMediumLabel.Size = new System.Drawing.Size(45, 16);
            this.HighMediumLabel.TabIndex = 2;
            this.HighMediumLabel.Text = "1000";
            this.HighMediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LowMediumLabel
            // 
            this.LowMediumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LowMediumLabel.BackColor = System.Drawing.Color.Silver;
            this.LowMediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowMediumLabel.Location = new System.Drawing.Point(0, 32);
            this.LowMediumLabel.Name = "LowMediumLabel";
            this.LowMediumLabel.Size = new System.Drawing.Size(45, 16);
            this.LowMediumLabel.TabIndex = 1;
            this.LowMediumLabel.Text = "100";
            this.LowMediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LowLabel
            // 
            this.LowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LowLabel.BackColor = System.Drawing.Color.Silver;
            this.LowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowLabel.Location = new System.Drawing.Point(0, 48);
            this.LowLabel.Name = "LowLabel";
            this.LowLabel.Size = new System.Drawing.Size(45, 16);
            this.LowLabel.TabIndex = 0;
            this.LowLabel.Text = "0";
            this.LowLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(45, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 64);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 17);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TimelinePanel);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(624, 17);
            this.panel6.TabIndex = 0;
            // 
            // TimelinePanel
            // 
            this.TimelinePanel.BackColor = System.Drawing.Color.Silver;
            this.TimelinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimelinePanel.Location = new System.Drawing.Point(45, 2);
            this.TimelinePanel.Name = "TimelinePanel";
            this.TimelinePanel.Size = new System.Drawing.Size(579, 15);
            this.TimelinePanel.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(45, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(579, 2);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(45, 17);
            this.panel7.TabIndex = 0;
            // 
            // Graph
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "Graph";
            this.Size = new System.Drawing.Size(628, 85);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.LabelPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LabelPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HighLabel;
        private System.Windows.Forms.Label HighMediumLabel;
        private System.Windows.Forms.Label LowMediumLabel;
        private System.Windows.Forms.Label LowLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel TimelinePanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}
