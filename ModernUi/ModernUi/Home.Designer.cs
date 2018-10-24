namespace ModernUi
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnQuit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpbCPU = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cpbRAM = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.LeftPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LeftPanel.Controls.Add(this.btnQuit);
            this.LeftPanel.Controls.Add(this.btnDashboard);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(20, 30);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(183, 400);
            this.LeftPanel.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Activecolor = System.Drawing.Color.DarkGray;
            this.btnQuit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.BorderRadius = 0;
            this.btnQuit.ButtonText = "                      Quit";
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQuit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuit.Iconimage = null;
            this.btnQuit.Iconimage_right = null;
            this.btnQuit.Iconimage_right_Selected = null;
            this.btnQuit.Iconimage_Selected = null;
            this.btnQuit.IconMarginLeft = 0;
            this.btnQuit.IconMarginRight = 0;
            this.btnQuit.IconRightVisible = true;
            this.btnQuit.IconRightZoom = 0D;
            this.btnQuit.IconVisible = true;
            this.btnQuit.IconZoom = 90D;
            this.btnQuit.IsTab = false;
            this.btnQuit.Location = new System.Drawing.Point(0, 352);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnQuit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuit.selected = false;
            this.btnQuit.Size = new System.Drawing.Size(183, 48);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "                      Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Textcolor = System.Drawing.Color.White;
            this.btnQuit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.DarkGray;
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "                Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = null;
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 90D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(0, 59);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(183, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "                Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogoPanel.Controls.Add(this.label1);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(183, 59);
            this.LogoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mixed Realities Nz";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(203, 30);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(577, 59);
            this.HeaderPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(252, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "DashBoard";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpbCPU
            // 
            this.cpbCPU.animated = false;
            this.cpbCPU.animationIterval = 5;
            this.cpbCPU.animationSpeed = 300;
            this.cpbCPU.BackColor = System.Drawing.Color.Transparent;
            this.cpbCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbCPU.BackgroundImage")));
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbCPU.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpbCPU.LabelVisible = true;
            this.cpbCPU.LineProgressThickness = 8;
            this.cpbCPU.LineThickness = 5;
            this.cpbCPU.Location = new System.Drawing.Point(281, 186);
            this.cpbCPU.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbCPU.MaxValue = 100;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbCPU.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpbCPU.Size = new System.Drawing.Size(201, 201);
            this.cpbCPU.TabIndex = 2;
            this.cpbCPU.Value = 0;
            // 
            // cpbRAM
            // 
            this.cpbRAM.animated = false;
            this.cpbRAM.animationIterval = 5;
            this.cpbRAM.animationSpeed = 300;
            this.cpbRAM.BackColor = System.Drawing.Color.Transparent;
            this.cpbRAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbRAM.BackgroundImage")));
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbRAM.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpbRAM.LabelVisible = true;
            this.cpbRAM.LineProgressThickness = 8;
            this.cpbRAM.LineThickness = 5;
            this.cpbRAM.Location = new System.Drawing.Point(518, 186);
            this.cpbRAM.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbRAM.MaxValue = 100;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbRAM.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpbRAM.Size = new System.Drawing.Size(201, 201);
            this.cpbRAM.TabIndex = 3;
            this.cpbRAM.Value = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "RAM";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpbRAM);
            this.Controls.Add(this.cpbCPU);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.LeftPanel);
            this.DisplayHeader = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Modern UI App";
            this.Load += new System.EventHandler(this.Home_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HeaderPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbCPU;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cpbRAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Diagnostics.PerformanceCounter pRAM;
    }
}

