using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_money_tracker_Core.Abstractions;

namespace SimpleMoneyTracker.WinForms.Implementation
{
    internal class ShowDataToUserWinForms : IShowDataToUser
    {
        public void RunDialog()
        {
            var showStatisticForm = new ShowStatisticForm();
            showStatisticForm.ShowDialog();
        }

        public void ShowSpendingGraph()
        {
            throw new NotImplementedException();
        }
    }
}
