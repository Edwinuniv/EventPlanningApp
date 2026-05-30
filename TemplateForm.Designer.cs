namespace Event_planner
{
    partial class TemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnFeedbackMenu = new System.Windows.Forms.Button();
            this.btnTasksMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.radioButtonPM = new System.Windows.Forms.RadioButton();
            this.radioButtonAM = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.LTemplates = new System.Windows.Forms.ListBox();
            this.btnCT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEvents = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.CreatedEventsL = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnTasksMenu
            // 
            this.btnTasksMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnTasksMenu.FlatAppearance.BorderSize = 0;
            this.btnTasksMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasksMenu.ForeColor = System.Drawing.Color.White;
            this.btnTasksMenu.Location = new System.Drawing.Point(-1, 87);
            this.btnTasksMenu.Name = "btnTasksMenu";
            this.btnTasksMenu.Size = new System.Drawing.Size(185, 50);
            this.btnTasksMenu.TabIndex = 3;
            this.btnTasksMenu.Text = "Tasks";
            this.btnTasksMenu.UseVisualStyleBackColor = false;
            this.btnTasksMenu.Click += new System.EventHandler(this.btnTasksMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 44);
            this.panel2.TabIndex = 104;
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
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 10;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1, 268);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 43);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(200, 444);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 125;
            // 
            // radioButtonPM
            // 
            this.radioButtonPM.AutoSize = true;
            this.radioButtonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPM.ForeColor = System.Drawing.Color.White;
            this.radioButtonPM.Location = new System.Drawing.Point(516, 101);
            this.radioButtonPM.Name = "radioButtonPM";
            this.radioButtonPM.Size = new System.Drawing.Size(58, 28);
            this.radioButtonPM.TabIndex = 124;
            this.radioButtonPM.TabStop = true;
            this.radioButtonPM.Text = "PM";
            this.radioButtonPM.UseVisualStyleBackColor = true;
            // 
            // radioButtonAM
            // 
            this.radioButtonAM.AutoSize = true;
            this.radioButtonAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAM.ForeColor = System.Drawing.Color.White;
            this.radioButtonAM.Location = new System.Drawing.Point(451, 101);
            this.radioButtonAM.Name = "radioButtonAM";
            this.radioButtonAM.Size = new System.Drawing.Size(59, 28);
            this.radioButtonAM.TabIndex = 123;
            this.radioButtonAM.TabStop = true;
            this.radioButtonAM.Text = "AM";
            this.radioButtonAM.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(205, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 122;
            this.label7.Text = "Minute:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(543, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 121;
            this.label6.Text = "Hour:";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.numericUpDownHour.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHour.Location = new System.Drawing.Point(624, 63);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHour.TabIndex = 119;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.numericUpDownMinute.ForeColor = System.Drawing.Color.White;
            this.numericUpDownMinute.Location = new System.Drawing.Point(303, 101);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinute.TabIndex = 120;
            // 
            // LTemplates
            // 
            this.LTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.LTemplates.ForeColor = System.Drawing.Color.White;
            this.LTemplates.FormattingEnabled = true;
            this.LTemplates.Location = new System.Drawing.Point(205, 187);
            this.LTemplates.Name = "LTemplates";
            this.LTemplates.Size = new System.Drawing.Size(555, 121);
            this.LTemplates.TabIndex = 118;
            // 
            // btnCT
            // 
            this.btnCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCT.ForeColor = System.Drawing.Color.White;
            this.btnCT.Location = new System.Drawing.Point(604, 122);
            this.btnCT.Name = "btnCT";
            this.btnCT.Size = new System.Drawing.Size(75, 45);
            this.btnCT.TabIndex = 113;
            this.btnCT.Text = "Create template";
            this.btnCT.UseVisualStyleBackColor = true;
            this.btnCT.Click += new System.EventHandler(this.btnCT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(198, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 112;
            this.label5.Text = "Event date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 111;
            // 
            // btnRSVP
            // 
            this.btnRSVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnRSVP.FlatAppearance.BorderSize = 0;
            this.btnRSVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSVP.ForeColor = System.Drawing.Color.White;
            this.btnRSVP.Location = new System.Drawing.Point(0, 132);
            this.btnRSVP.Name = "btnRSVP";
            this.btnRSVP.Size = new System.Drawing.Size(179, 59);
            this.btnRSVP.TabIndex = 10;
            this.btnRSVP.Text = "RSVP";
            this.btnRSVP.UseVisualStyleBackColor = false;
            this.btnRSVP.Click += new System.EventHandler(this.btnRSVP_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(1, 187);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(179, 43);
            this.btnReports.TabIndex = 9;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(1, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 140);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 140);
            this.panel5.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 303);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Controls.Add(this.btnRSVP);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFeedbackMenu);
            this.panel1.Controls.Add(this.btnTasksMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 492);
            this.panel1.TabIndex = 103;
            // 
            // btnEvents
            // 
            this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.ForeColor = System.Drawing.Color.White;
            this.btnEvents.Location = new System.Drawing.Point(-1, 45);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(185, 46);
            this.btnEvents.TabIndex = 11;
            this.btnEvents.Text = "Events";
            this.btnEvents.UseVisualStyleBackColor = false;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CreatedEventsL
            // 
            this.CreatedEventsL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.CreatedEventsL.ForeColor = System.Drawing.Color.White;
            this.CreatedEventsL.FormattingEnabled = true;
            this.CreatedEventsL.Location = new System.Drawing.Point(203, 314);
            this.CreatedEventsL.Name = "CreatedEventsL";
            this.CreatedEventsL.Size = new System.Drawing.Size(555, 121);
            this.CreatedEventsL.TabIndex = 126;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.CreatedEventsL);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.radioButtonPM);
            this.Controls.Add(this.radioButtonAM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.LTemplates);
            this.Controls.Add(this.btnCT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFeedbackMenu;
        private System.Windows.Forms.Button btnTasksMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioButtonPM;
        private System.Windows.Forms.RadioButton radioButtonAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.ListBox LTemplates;
        private System.Windows.Forms.Button btnCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox CreatedEventsL;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Panel panel5;
    }
}