namespace Event_planner
{
    partial class BudgetForm
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
            this.btnDone = new System.Windows.Forms.Button();
            this.Tasks = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Expenses = new System.Windows.Forms.ListBox();
            this.btnSetBudget = new System.Windows.Forms.Button();
            this.BtnAddExpenses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtTotalBudget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(313, 168);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(93, 23);
            this.btnDone.TabIndex = 122;
            this.btnDone.Text = "Close";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Tasks.ForeColor = System.Drawing.Color.White;
            this.Tasks.FormattingEnabled = true;
            this.Tasks.Location = new System.Drawing.Point(288, 40);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(134, 108);
            this.Tasks.TabIndex = 121;
            this.Tasks.SelectedIndexChanged += new System.EventHandler(this.Tasks_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(63, 374);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 120;
            // 
            // Expenses
            // 
            this.Expenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            this.Expenses.ForeColor = System.Drawing.Color.White;
            this.Expenses.FormattingEnabled = true;
            this.Expenses.Location = new System.Drawing.Point(52, 224);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(273, 147);
            this.Expenses.TabIndex = 119;
            // 
            // btnSetBudget
            // 
            this.btnSetBudget.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSetBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetBudget.ForeColor = System.Drawing.Color.White;
            this.btnSetBudget.Location = new System.Drawing.Point(54, 168);
            this.btnSetBudget.Name = "btnSetBudget";
            this.btnSetBudget.Size = new System.Drawing.Size(82, 23);
            this.btnSetBudget.TabIndex = 118;
            this.btnSetBudget.Text = "Set Budget";
            this.btnSetBudget.UseVisualStyleBackColor = true;
            this.btnSetBudget.Click += new System.EventHandler(this.btnSetBudget_Click);
            // 
            // BtnAddExpenses
            // 
            this.BtnAddExpenses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddExpenses.ForeColor = System.Drawing.Color.White;
            this.BtnAddExpenses.Location = new System.Drawing.Point(165, 168);
            this.BtnAddExpenses.Name = "BtnAddExpenses";
            this.BtnAddExpenses.Size = new System.Drawing.Size(93, 23);
            this.BtnAddExpenses.TabIndex = 117;
            this.BtnAddExpenses.Text = "Add Expenses";
            this.BtnAddExpenses.UseVisualStyleBackColor = true;
            this.BtnAddExpenses.Click += new System.EventHandler(this.BtnAddExpenses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 116;
            this.label4.Text = "Total Budget:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 115;
            this.label1.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(160, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "Task name:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(180, 123);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 113;
            // 
            // txtTotalBudget
            // 
            this.txtTotalBudget.Location = new System.Drawing.Point(180, 83);
            this.txtTotalBudget.Name = "txtTotalBudget";
            this.txtTotalBudget.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBudget.TabIndex = 112;
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(472, 434);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.Tasks);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.btnSetBudget);
            this.Controls.Add(this.BtnAddExpenses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtTotalBudget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetForm";
            this.Load += new System.EventHandler(this.BudgetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox Tasks;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox Expenses;
        private System.Windows.Forms.Button btnSetBudget;
        private System.Windows.Forms.Button BtnAddExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtTotalBudget;
    }
}