namespace Event_planner
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.btnExport = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.Events = new System.Windows.Forms.ListBox();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnEventsMenu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTemplatesMenu = new System.Windows.Forms.Button();
            this.btnTasksMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedbackMenu = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(351, 425);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(79, 53);
            this.btnExport.TabIndex = 113;
            this.btnExport.Text = "Export report";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtReport
            // 
            this.txtReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtReport.Location = new System.Drawing.Point(622, 73);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReport.Size = new System.Drawing.Size(320, 388);
            this.txtReport.TabIndex = 111;
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Events.ForeColor = System.Drawing.Color.White;
            this.Events.FormattingEnabled = true;
            this.Events.Location = new System.Drawing.Point(199, 77);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(406, 342);
            this.Events.TabIndex = 109;
            // 
            // btnRSVP
            // 
            this.btnRSVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnRSVP.FlatAppearance.BorderSize = 0;
            this.btnRSVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSVP.ForeColor = System.Drawing.Color.White;
            this.btnRSVP.Location = new System.Drawing.Point(0, 123);
            this.btnRSVP.Name = "btnRSVP";
            this.btnRSVP.Size = new System.Drawing.Size(179, 59);
            this.btnRSVP.TabIndex = 10;
            this.btnRSVP.Text = "RSVP";
            this.btnRSVP.UseVisualStyleBackColor = false;
            this.btnRSVP.Click += new System.EventHandler(this.btnRSVP_Click);
            // 
            // btnEventsMenu
            // 
            this.btnEventsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnEventsMenu.FlatAppearance.BorderSize = 0;
            this.btnEventsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventsMenu.ForeColor = System.Drawing.Color.White;
            this.btnEventsMenu.Location = new System.Drawing.Point(0, 44);
            this.btnEventsMenu.Name = "btnEventsMenu";
            this.btnEventsMenu.Size = new System.Drawing.Size(179, 43);
            this.btnEventsMenu.TabIndex = 9;
            this.btnEventsMenu.Text = "Events";
            this.btnEventsMenu.UseVisualStyleBackColor = false;
            this.btnEventsMenu.Click += new System.EventHandler(this.btnEventsMenu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 235);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 182);
            this.panel5.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1, 268);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 44);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Profile";
            // 
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 10;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.White;
            this.lblEvent.Location = new System.Drawing.Point(0, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(135, 25);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event Planner";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 44);
            this.panel2.TabIndex = 107;
            // 
            // btnTemplatesMenu
            // 
            this.btnTemplatesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnTemplatesMenu.FlatAppearance.BorderSize = 0;
            this.btnTemplatesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplatesMenu.ForeColor = System.Drawing.Color.White;
            this.btnTemplatesMenu.Location = new System.Drawing.Point(1, 180);
            this.btnTemplatesMenu.Name = "btnTemplatesMenu";
            this.btnTemplatesMenu.Size = new System.Drawing.Size(179, 50);
            this.btnTemplatesMenu.TabIndex = 5;
            this.btnTemplatesMenu.Text = "Templates";
            this.btnTemplatesMenu.UseVisualStyleBackColor = false;
            this.btnTemplatesMenu.Click += new System.EventHandler(this.btnTemplatesMenu_Click);
            // 
            // btnTasksMenu
            // 
            this.btnTasksMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnTasksMenu.FlatAppearance.BorderSize = 0;
            this.btnTasksMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasksMenu.ForeColor = System.Drawing.Color.White;
            this.btnTasksMenu.Location = new System.Drawing.Point(-5, 86);
            this.btnTasksMenu.Name = "btnTasksMenu";
            this.btnTasksMenu.Size = new System.Drawing.Size(185, 40);
            this.btnTasksMenu.TabIndex = 3;
            this.btnTasksMenu.Text = "Tasks";
            this.btnTasksMenu.UseVisualStyleBackColor = false;
            this.btnTasksMenu.Click += new System.EventHandler(this.btnTasksMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(689, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 112;
            this.label2.Text = "Report";
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(263, 425);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(82, 53);
            this.btnGenerate.TabIndex = 108;
            this.btnGenerate.Text = "Generate report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRSVP);
            this.panel1.Controls.Add(this.btnEventsMenu);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnFeedbackMenu);
            this.panel1.Controls.Add(this.btnTemplatesMenu);
            this.panel1.Controls.Add(this.btnTasksMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 533);
            this.panel1.TabIndex = 106;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 309);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 55);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnFeedbackMenu
            // 
            this.btnFeedbackMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnFeedbackMenu.FlatAppearance.BorderSize = 0;
            this.btnFeedbackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedbackMenu.ForeColor = System.Drawing.Color.White;
            this.btnFeedbackMenu.Location = new System.Drawing.Point(1, 230);
            this.btnFeedbackMenu.Name = "btnFeedbackMenu";
            this.btnFeedbackMenu.Size = new System.Drawing.Size(179, 39);
            this.btnFeedbackMenu.TabIndex = 6;
            this.btnFeedbackMenu.Text = "Feedback";
            this.btnFeedbackMenu.UseVisualStyleBackColor = false;
            this.btnFeedbackMenu.Click += new System.EventHandler(this.btnFeedbackMenu_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(320, 42);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 110;
            // 
            // btnShare
            // 
            this.btnShare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.ForeColor = System.Drawing.Color.White;
            this.btnShare.Location = new System.Drawing.Point(436, 425);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(79, 53);
            this.btnShare.TabIndex = 114;
            this.btnShare.Text = "Share report";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 115;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.ListBox Events;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnEventsMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTemplatesMenu;
        private System.Windows.Forms.Button btnTasksMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFeedbackMenu;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
    }
}