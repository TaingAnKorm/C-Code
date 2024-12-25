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
    public partial class frmSalaryTaxCalculator : Form
    {
        public frmSalaryTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double salary = string.IsNullOrWhiteSpace(textSalary.Text) ? 0.0 : double.Parse(textSalary.Text);
            double bonus = string.IsNullOrWhiteSpace(textBonus.Text) ? 0.0 : double.Parse(textBonus.Text);
            int spouse = string.IsNullOrWhiteSpace(textSpouse.Text) ? 0 : int.Parse(textSpouse.Text);
            int children = string.IsNullOrWhiteSpace(NumofChild.Text) ? 0 : int.Parse(NumofChild.Text);

            if (salary >= 0 && bonus >= 0)
            {
                spouse = spouse >= 1 ? 1 : 0;
                children = children >= 9 ? 9 : (children <= 0 ? 0 : children);

                textSpouse.Text = spouse.ToString();
                NumofChild.Text = children.ToString();

                double tax, lastSalary;
                double family = (spouse + children) * 150000;
                salary -= family;

                if (salary <= 1200000)
                    tax = 0;
                else if (salary <= 2000000)
                    tax = salary * 0.05 - 60000;
                else if (salary <= 8500000)
                    tax = salary * 0.1 - 160000;
                else if (salary <= 12500000)
                    tax = salary * 0.15 - 585000;
                else
                    tax = salary * 0.2 - 1210000;

                tax += bonus * 0.2;
                lastSalary = (salary + family + bonus) - tax;

                lblTax.Text = tax.ToString("#,##0.## KHR");
                lblLastSalary.Text = lastSalary.ToString("#,##0.## KHR");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void lblLastSalary_Click(object sender, EventArgs e)
        {

        }
    }
}
