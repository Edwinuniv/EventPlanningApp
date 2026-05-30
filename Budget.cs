using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public class Budget
    {
        public double Totalb;
        public double Totalexpenses;
        public Dictionary<string, double> expensesItems = new Dictionary<string, double>();

        public Budget()
        {
            expensesItems = new Dictionary<string, double>();
            Totalb = 0;
            Totalexpenses = 0;
        }

        public void SetBudget(double amount)
        {
            Totalb = amount;
        }

        public void AddExpenses(string taskname, double cost)
        {
            if (expensesItems.ContainsKey(taskname))
            {
                expensesItems[taskname] += cost;
            }
            else
            {
                expensesItems.Add(taskname, cost);
            }
            Totalexpenses += cost;
        }

        public double GetRemainingBudget()
        {
            double result = Totalb - Totalexpenses;
            return result;
        }
    }
}
