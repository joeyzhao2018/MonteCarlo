using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarlo.CustomControl
{
    public partial class TaskControl : UserControl
    {
        public TaskControl()
        {
            InitializeComponent();
        }

        private void txbTaskCost_Enter(object sender, EventArgs e)
        {
            if (txbTaskCost.Text == "Task Cost")
            {
                txbTaskCost.Text = "";
            }
        }

        private void txbTaskCost_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Task Costing", txbTaskCost);
        }
    }
}
