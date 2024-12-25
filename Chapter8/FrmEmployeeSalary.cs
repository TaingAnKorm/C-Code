using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string empName = txtEmployee.Text;
            int hours = int.Parse(txtHours.Text);
            double wage = Convert.ToDouble(txtWage.Text);
            double result = hours * wage;

            txtResuit.Text = result.ToString() + "$";

        }
    }
}
