using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime Selected;
        private void calcBtn_Click(object sender, EventArgs e)
        {
            decimal Total = totalAmount.Value;
            DateTime today = calander.TodayDate;

            //assume in the future
            //possibly add check later to make sure it's positive
            //ie no date is selected in the past
            TimeSpan period = Selected.Subtract(today);

            calcedDailyAmountTxt.Text = ((int)Total / period.Days).ToString();
            calcedWeeklyAmounTxt.Text = ((int)Total / ((float)period.Days / 7.0f)).ToString();
            calcedMonthlyAmountTxt.Text = ((int)Total / DateTime.DaysInMonth(DateTime.Now.Year, Selected.Month)).ToString();
        }

        private void calander_DateSelected(object sender, DateRangeEventArgs e)
        {
            Selected = e.Start;
        }
    }
}
