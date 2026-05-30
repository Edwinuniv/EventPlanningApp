namespace Event_planner
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.radioButtonPM = new System.Windows.Forms.RadioButton();
            this.radioButtonAM = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.Events = new System.Windows.Forms.ListBox();
            this.btnEditevent = new System.Windows.Forms.Button();
            this.btnDeleteevent = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnaddevent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedbackMenu = new System.Windows.Forms.Button();
            this.btnTemplatesMenu = new System.Windows.Forms.Button();
            this.btnTasksMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(199, 435);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 102;
            // 
            // radioButtonPM
            // 
            this.radioButtonPM.AutoSize = true;
            this.radioButtonPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPM.ForeColor = System.Drawing.Color.White;
            this.radioButtonPM.Location = new System.Drawing.Point(742, 144);
            this.radioButtonPM.Name = "radioButtonPM";
            this.radioButtonPM.Size = new System.Drawing.Size(58, 28);
            this.radioButtonPM.TabIndex = 101;
            this.radioButtonPM.TabStop = true;
            this.radioButtonPM.Text = "PM";
            this.radioButtonPM.UseVisualStyleBackColor = true;
            // 
            // radioButtonAM
            // 
            this.radioButtonAM.AutoSize = true;
            this.radioButtonAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAM.ForeColor = System.Drawing.Color.White;
            this.radioButtonAM.Location = new System.Drawing.Point(677, 144);
            this.radioButtonAM.Name = "radioButtonAM";
            this.radioButtonAM.Size = new System.Drawing.Size(59, 28);
            this.radioButtonAM.TabIndex = 100;
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
            this.label7.Location = new System.Drawing.Point(445, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 99;
            this.label7.Text = "Minute:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(240, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 98;
            this.label6.Text = "Hour:";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.numericUpDownHour.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHour.Location = new System.Drawing.Point(321, 149);
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHour.TabIndex = 96;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.numericUpDownMinute.ForeColor = System.Drawing.Color.White;
            this.numericUpDownMinute.Location = new System.Drawing.Point(543, 149);
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinute.TabIndex = 97;
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Events.ForeColor = System.Drawing.Color.White;
            this.Events.FormattingEnabled = true;
            this.Events.Location = new System.Drawing.Point(200, 308);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(555, 121);
            this.Events.TabIndex = 95;
            // 
            // btnEditevent
            // 
            this.btnEditevent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditevent.ForeColor = System.Drawing.Color.White;
            this.btnEditevent.Location = new System.Drawing.Point(291, 190);
            this.btnEditevent.Name = "btnEditevent";
            this.btnEditevent.Size = new System.Drawing.Size(82, 23);
            this.btnEditevent.TabIndex = 94;
            this.btnEditevent.Text = "Edit event";
            this.btnEditevent.UseVisualStyleBackColor = true;
            this.btnEditevent.Click += new System.EventHandler(this.btnEditevent_Click);
            // 
            // btnDeleteevent
            // 
            this.btnDeleteevent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteevent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteevent.Location = new System.Drawing.Point(379, 190);
            this.btnDeleteevent.Name = "btnDeleteevent";
            this.btnDeleteevent.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteevent.TabIndex = 93;
            this.btnDeleteevent.Text = "Delete event";
            this.btnDeleteevent.UseVisualStyleBackColor = true;
            this.btnDeleteevent.Click += new System.EventHandler(this.btnDeleteevent_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.ForeColor = System.Drawing.Color.White;
            this.btnhistory.Location = new System.Drawing.Point(210, 223);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(75, 71);
            this.btnhistory.TabIndex = 92;
            this.btnhistory.Text = "load previous events";
            this.btnhistory.UseVisualStyleBackColor = true;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // btnload
            // 
            this.btnload.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnload.ForeColor = System.Drawing.Color.White;
            this.btnload.Location = new System.Drawing.Point(291, 223);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(75, 71);
            this.btnload.TabIndex = 91;
            this.btnload.Text = "Load upcomming events";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnaddevent
            // 
            this.btnaddevent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnaddevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddevent.ForeColor = System.Drawing.Color.White;
            this.btnaddevent.Location = new System.Drawing.Point(210, 190);
            this.btnaddevent.Name = "btnaddevent";
            this.btnaddevent.Size = new System.Drawing.Size(75, 23);
            this.btnaddevent.TabIndex = 90;
            this.btnaddevent.Text = "Add event";
            this.btnaddevent.UseVisualStyleBackColor = true;
            this.btnaddevent.Click += new System.EventHandler(this.btnaddevent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(439, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Event date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(555, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(439, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 87;
            this.label4.Text = "Event location:";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(593, 55);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(105, 20);
            this.txtLocation.TabIndex = 86;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtEventType
            // 
            this.txtEventType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtEventType.ForeColor = System.Drawing.Color.White;
            this.txtEventType.Location = new System.Drawing.Point(321, 103);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(105, 20);
            this.txtEventType.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnRSVP);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFeedbackMenu);
            this.panel1.Controls.Add(this.btnTemplatesMenu);
            this.panel1.Controls.Add(this.btnTasksMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 487);
            this.panel1.TabIndex = 80;
            // 
            // btnRSVP
            // 
            this.btnRSVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnRSVP.FlatAppearance.BorderSize = 0;
            this.btnRSVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSVP.ForeColor = System.Drawing.Color.White;
            this.btnRSVP.Location = new System.Drawing.Point(0, 80);
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
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(1, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 135);
            this.panel4.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
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
            // btnTemplatesMenu
            // 
            this.btnTemplatesMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnTemplatesMenu.FlatAppearance.BorderSize = 0;
            this.btnTemplatesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplatesMenu.ForeColor = System.Drawing.Color.White;
            this.btnTemplatesMenu.Location = new System.Drawing.Point(1, 137);
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
            this.btnTasksMenu.Location = new System.Drawing.Point(-5, 43);
            this.btnTasksMenu.Name = "btnTasksMenu";
            this.btnTasksMenu.Size = new System.Drawing.Size(185, 40);
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
            this.panel2.TabIndex = 81;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(195, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 84;
            this.label3.Text = "Event type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(195, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Event name:";
            // 
            // txtEventname
            // 
            this.txtEventname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtEventname.ForeColor = System.Drawing.Color.White;
            this.txtEventname.Location = new System.Drawing.Point(321, 54);
            this.txtEventname.Name = "txtEventname";
            this.txtEventname.Size = new System.Drawing.Size(105, 20);
            this.txtEventname.TabIndex = 82;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.radioButtonPM);
            this.Controls.Add(this.radioButtonAM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.btnEditevent);
            this.Controls.Add(this.btnDeleteevent);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnaddevent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radioButtonPM;
        private System.Windows.Forms.RadioButton radioButtonAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.ListBox Events;
        private System.Windows.Forms.Button btnEditevent;
        private System.Windows.Forms.Button btnDeleteevent;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnaddevent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedbackMenu;
        private System.Windows.Forms.Button btnTemplatesMenu;
        private System.Windows.Forms.Button btnTasksMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventname;
    }
}