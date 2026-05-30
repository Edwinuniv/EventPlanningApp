namespace Event_planner
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.btnBudgetmenu = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskname = new System.Windows.Forms.TextBox();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRSVP = new System.Windows.Forms.Button();
            this.btnEventMenu = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedbackMenu = new System.Windows.Forms.Button();
            this.btnTemplatesMenu = new System.Windows.Forms.Button();
            this.btnLoadTasks = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Events = new System.Windows.Forms.ListBox();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTaskpriority = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBudgetmenu
            // 
            this.btnBudgetmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnBudgetmenu.FlatAppearance.BorderSize = 0;
            this.btnBudgetmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudgetmenu.ForeColor = System.Drawing.Color.White;
            this.btnBudgetmenu.Location = new System.Drawing.Point(463, 89);
            this.btnBudgetmenu.Name = "btnBudgetmenu";
            this.btnBudgetmenu.Size = new System.Drawing.Size(99, 34);
            this.btnBudgetmenu.TabIndex = 122;
            this.btnBudgetmenu.Text = "Budget";
            this.btnBudgetmenu.UseVisualStyleBackColor = false;
            this.btnBudgetmenu.Click += new System.EventHandler(this.btnBudgetmenu_Click);
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Tasks.ForeColor = System.Drawing.Color.White;
            this.Tasks.FormattingEnabled = true;
            this.Tasks.Location = new System.Drawing.Point(186, 288);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(573, 108);
            this.Tasks.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "Task Description:";
            // 
            // txtTaskname
            // 
            this.txtTaskname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtTaskname.ForeColor = System.Drawing.Color.White;
            this.txtTaskname.Location = new System.Drawing.Point(329, 53);
            this.txtTaskname.Name = "txtTaskname";
            this.txtTaskname.Size = new System.Drawing.Size(105, 20);
            this.txtTaskname.TabIndex = 109;
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
            this.panel2.Size = new System.Drawing.Size(621, 44);
            this.panel2.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(196, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 110;
            this.label2.Text = "Task name:";
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
            // btnRSVP
            // 
            this.btnRSVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnRSVP.FlatAppearance.BorderSize = 0;
            this.btnRSVP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRSVP.ForeColor = System.Drawing.Color.White;
            this.btnRSVP.Location = new System.Drawing.Point(0, 91);
            this.btnRSVP.Name = "btnRSVP";
            this.btnRSVP.Size = new System.Drawing.Size(179, 53);
            this.btnRSVP.TabIndex = 11;
            this.btnRSVP.Text = "RSVP";
            this.btnRSVP.UseVisualStyleBackColor = false;
            this.btnRSVP.Click += new System.EventHandler(this.btnRSVP_Click);
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
            this.btnEventMenu.TabIndex = 10;
            this.btnEventMenu.Text = "Events";
            this.btnEventMenu.UseVisualStyleBackColor = false;
            this.btnEventMenu.Click += new System.EventHandler(this.btnEventMenu_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(1, 193);
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
            this.panel4.Location = new System.Drawing.Point(1, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 132);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(178, 135);
            this.panel5.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 309);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(179, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnRSVP);
            this.panel1.Controls.Add(this.btnEventMenu);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFeedbackMenu);
            this.panel1.Controls.Add(this.btnTemplatesMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 477);
            this.panel1.TabIndex = 107;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1, 274);
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
            this.btnFeedbackMenu.Location = new System.Drawing.Point(1, 236);
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
            this.btnTemplatesMenu.Location = new System.Drawing.Point(1, 143);
            this.btnTemplatesMenu.Name = "btnTemplatesMenu";
            this.btnTemplatesMenu.Size = new System.Drawing.Size(179, 50);
            this.btnTemplatesMenu.TabIndex = 5;
            this.btnTemplatesMenu.Text = "Templates";
            this.btnTemplatesMenu.UseVisualStyleBackColor = false;
            this.btnTemplatesMenu.Click += new System.EventHandler(this.btnTemplatesMenu_Click);
            // 
            // btnLoadTasks
            // 
            this.btnLoadTasks.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoadTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTasks.ForeColor = System.Drawing.Color.White;
            this.btnLoadTasks.Location = new System.Drawing.Point(482, 139);
            this.btnLoadTasks.Name = "btnLoadTasks";
            this.btnLoadTasks.Size = new System.Drawing.Size(82, 23);
            this.btnLoadTasks.TabIndex = 121;
            this.btnLoadTasks.Text = "Load tasks";
            this.btnLoadTasks.UseVisualStyleBackColor = true;
            this.btnLoadTasks.Click += new System.EventHandler(this.btnLoadTasks_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(199, 430);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 118;
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Events.ForeColor = System.Drawing.Color.White;
            this.Events.FormattingEnabled = true;
            this.Events.Location = new System.Drawing.Point(186, 179);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(573, 95);
            this.Events.TabIndex = 117;
            this.Events.SelectedIndexChanged += new System.EventHandler(this.Events_SelectedIndexChanged);
            // 
            // btnEditTask
            // 
            this.btnEditTask.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(295, 139);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(82, 23);
            this.btnEditTask.TabIndex = 116;
            this.btnEditTask.Text = "Edit task";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(394, 139);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteTask.TabIndex = 115;
            this.btnDeleteTask.Text = "Delete task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(205, 139);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 114;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(626, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(105, 20);
            this.txtDescription.TabIndex = 113;
            // 
            // txtTaskpriority
            // 
            this.txtTaskpriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.txtTaskpriority.ForeColor = System.Drawing.Color.White;
            this.txtTaskpriority.Location = new System.Drawing.Point(329, 103);
            this.txtTaskpriority.Name = "txtTaskpriority";
            this.txtTaskpriority.Size = new System.Drawing.Size(105, 20);
            this.txtTaskpriority.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(196, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 111;
            this.label3.Text = "Task priority:";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.btnBudgetmenu);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTaskname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadTasks);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskpriority);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBudgetmenu;
        private System.Windows.Forms.ListBox Tasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskname;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRSVP;
        private System.Windows.Forms.Button btnEventMenu;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedbackMenu;
        private System.Windows.Forms.Button btnTemplatesMenu;
        private System.Windows.Forms.Button btnLoadTasks;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox Events;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTaskpriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
    }
}