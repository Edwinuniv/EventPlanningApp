namespace Event_planner
{
    partial class RSVPtrackingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSVPtrackingForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.Guests = new System.Windows.Forms.ListBox();
            this.btnLoadguest = new System.Windows.Forms.Button();
            this.btnDeleteguest = new System.Windows.Forms.Button();
            this.btnEditGuest = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.Events = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedbackMenu = new System.Windows.Forms.Button();
            this.btnTemplatesMenu = new System.Windows.Forms.Button();
            this.btnTasksMenu = new System.Windows.Forms.Button();
            this.btnEventMenu = new System.Windows.Forms.Button();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnAddguest = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lblInfo.Location = new System.Drawing.Point(205, 459);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 131;
            // 
            // Guests
            // 
            this.Guests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Guests.ForeColor = System.Drawing.Color.White;
            this.Guests.FormattingEnabled = true;
            this.Guests.Location = new System.Drawing.Point(215, 345);
            this.Guests.Name = "Guests";
            this.Guests.Size = new System.Drawing.Size(573, 95);
            this.Guests.TabIndex = 130;
            // 
            // btnLoadguest
            // 
            this.btnLoadguest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoadguest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadguest.ForeColor = System.Drawing.Color.White;
            this.btnLoadguest.Location = new System.Drawing.Point(512, 181);
            this.btnLoadguest.Name = "btnLoadguest";
            this.btnLoadguest.Size = new System.Drawing.Size(82, 43);
            this.btnLoadguest.TabIndex = 129;
            this.btnLoadguest.Text = "Load guests";
            this.btnLoadguest.UseVisualStyleBackColor = true;
            this.btnLoadguest.Click += new System.EventHandler(this.btnLoadguest_Click);
            // 
            // btnDeleteguest
            // 
            this.btnDeleteguest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteguest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteguest.ForeColor = System.Drawing.Color.White;
            this.btnDeleteguest.Location = new System.Drawing.Point(413, 181);
            this.btnDeleteguest.Name = "btnDeleteguest";
            this.btnDeleteguest.Size = new System.Drawing.Size(82, 43);
            this.btnDeleteguest.TabIndex = 128;
            this.btnDeleteguest.Text = "Delete guest";
            this.btnDeleteguest.UseVisualStyleBackColor = true;
            this.btnDeleteguest.Click += new System.EventHandler(this.btnDeleteguest_Click);
            // 
            // btnEditGuest
            // 
            this.btnEditGuest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGuest.ForeColor = System.Drawing.Color.White;
            this.btnEditGuest.Location = new System.Drawing.Point(316, 181);
            this.btnEditGuest.Name = "btnEditGuest";
            this.btnEditGuest.Size = new System.Drawing.Size(82, 43);
            this.btnEditGuest.TabIndex = 127;
            this.btnEditGuest.Text = "Edit guest";
            this.btnEditGuest.UseVisualStyleBackColor = true;
            this.btnEditGuest.Click += new System.EventHandler(this.btnEditGuest_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(350, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(105, 20);
            this.txtEmail.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(187, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 125;
            this.label6.Text = "Guest email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Location = new System.Drawing.Point(636, 92);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(105, 20);
            this.txtPhoneNumber.TabIndex = 124;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(479, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 123;
            this.label5.Text = "Phone number:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.Location = new System.Drawing.Point(636, 60);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(105, 20);
            this.txtAge.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(479, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 121;
            this.label4.Text = "Guest age:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(350, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(105, 20);
            this.txtLastName.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "Guest last name:";
            // 
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 10;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Events.ForeColor = System.Drawing.Color.White;
            this.Events.FormattingEnabled = true;
            this.Events.Location = new System.Drawing.Point(215, 242);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(573, 95);
            this.Events.TabIndex = 118;
            this.Events.SelectedIndexChanged += new System.EventHandler(this.Events_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFeedbackMenu);
            this.panel1.Controls.Add(this.btnTemplatesMenu);
            this.panel1.Controls.Add(this.btnTasksMenu);
            this.panel1.Controls.Add(this.btnEventMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 509);
            this.panel1.TabIndex = 113;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 299);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 49);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 179);
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
            this.panel4.Location = new System.Drawing.Point(1, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 161);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 161);
            this.panel5.TabIndex = 9;
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
            this.btnLogout.Location = new System.Drawing.Point(0, 260);
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
            this.btnFeedbackMenu.Location = new System.Drawing.Point(0, 222);
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
            this.btnTemplatesMenu.Location = new System.Drawing.Point(0, 129);
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
            this.btnTasksMenu.Location = new System.Drawing.Point(-6, 89);
            this.btnTasksMenu.Name = "btnTasksMenu";
            this.btnTasksMenu.Size = new System.Drawing.Size(185, 40);
            this.btnTasksMenu.TabIndex = 3;
            this.btnTasksMenu.Text = "Tasks";
            this.btnTasksMenu.UseVisualStyleBackColor = false;
            this.btnTasksMenu.Click += new System.EventHandler(this.btnTasksMenu_Click);
            // 
            // btnEventMenu
            // 
            this.btnEventMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnEventMenu.FlatAppearance.BorderSize = 0;
            this.btnEventMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMenu.ForeColor = System.Drawing.Color.White;
            this.btnEventMenu.Location = new System.Drawing.Point(0, 44);
            this.btnEventMenu.Name = "btnEventMenu";
            this.btnEventMenu.Size = new System.Drawing.Size(179, 49);
            this.btnEventMenu.TabIndex = 2;
            this.btnEventMenu.Text = "Events";
            this.btnEventMenu.UseVisualStyleBackColor = false;
            this.btnEventMenu.Click += new System.EventHandler(this.btnEventMenu_Click);
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
            // btnAddguest
            // 
            this.btnAddguest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddguest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddguest.ForeColor = System.Drawing.Color.White;
            this.btnAddguest.Location = new System.Drawing.Point(215, 181);
            this.btnAddguest.Name = "btnAddguest";
            this.btnAddguest.Size = new System.Drawing.Size(82, 43);
            this.btnAddguest.TabIndex = 117;
            this.btnAddguest.Text = "Add guest";
            this.btnAddguest.UseVisualStyleBackColor = true;
            this.btnAddguest.Click += new System.EventHandler(this.btnAddguest_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(350, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(105, 20);
            this.txtName.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "Guest name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 44);
            this.panel2.TabIndex = 114;
            // 
            // RSVPtrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Guests);
            this.Controls.Add(this.btnLoadguest);
            this.Controls.Add(this.btnDeleteguest);
            this.Controls.Add(this.btnEditGuest);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddguest);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RSVPtrackingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSVPtrackingForm";
            this.Load += new System.EventHandler(this.RSVPtrackingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox Guests;
        private System.Windows.Forms.Button btnLoadguest;
        private System.Windows.Forms.Button btnDeleteguest;
        private System.Windows.Forms.Button btnEditGuest;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.ListBox Events;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFeedbackMenu;
        private System.Windows.Forms.Button btnTemplatesMenu;
        private System.Windows.Forms.Button btnTasksMenu;
        private System.Windows.Forms.Button btnEventMenu;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Button btnAddguest;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel5;
    }
}