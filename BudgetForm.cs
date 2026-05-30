using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_planner
{
    public partial class BudgetForm : Form
    {
        private Budget b;
        public List<Tasks> tasks;
        public Budget GetBudget()
        {
            return this.b;
        }
        public BudgetForm(Budget b, List<Tasks> tasks)
        {
            InitializeComponent();
            this.b = b;
            this.tasks = tasks;
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void btnSetBudget_Click(object sender, EventArgs e)
        {
            double budget;
            bool valid = double.TryParse(txtTotalBudget.Text, out budget);
            if (valid)
            {
                b.SetBudget(budget);
                lblInfo.Text = $"Budget set to {budget}$ ";
            }
            else
            {
                lblInfo.Text = "Invalid budget";
            }
        }
        public int SelectedIndex
        {
            set
            {
                if (value > 0 && value < Tasks.Items.Count)
                {
                    Tasks.SelectedIndex = value;
                    Tasks selectedT = tasks[value];
                    UpdateExpensesList(selectedT);
                    remainingvalue(selectedT);
                }
            }
        }

        private void BtnAddExpenses_Click(object sender, EventArgs e)
        {
            if (Tasks.SelectedIndex == -1)
            {
                lblInfo.Text = "Please select a task";
                return;
            }

            Tasks selectedtask = tasks[Tasks.SelectedIndex];

            double cost;
            bool valid = double.TryParse(txtCost.Text, out cost);
            if (!valid)
            {
                lblInfo.Text = "Please enter a cost";
                return;
            }

            if (b.expensesItems.ContainsKey(selectedtask.task_Name))
            {
                b.expensesItems[selectedtask.task_Name] += cost;
            }
            else
            {
                b.expensesItems.Add(selectedtask.task_Name, cost);
            }
            UpdateExpensesList(selectedtask);
            remainingvalue(selectedtask);
            txtCost.Clear();
        }
        private void UpdateExpensesList(Tasks t)
        {
            Expenses.Items.Clear();
            foreach (var b1 in b.expensesItems)
            {
                Expenses.Items.Add("Expenses: " + b1.Value + "$");
            }
        }

        private void remainingvalue(Tasks t)
        {
            lblInfo.Text = b.GetRemainingBudget().ToString() + "$";
        }

        private void LoadTasks()
        {
            Tasks.Items.Clear();
            foreach (Tasks t in tasks)
            {
                Tasks.Items.Add(t.task_Name);
            }
        }

        private void Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tasks.SelectedIndex == -1)
            {
                Tasks selectT = tasks[Tasks.SelectedIndex];
                UpdateExpensesList(selectT);
                remainingvalue(selectT);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            NotificationForm n = new NotificationForm("Notification", "Budget added");
            n.Show();
            this.Close();
        }
    }
}
