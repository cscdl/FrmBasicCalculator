using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssemblyyy;

namespace FrmBasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(txtFirsTNum.Text);
            float Num2 = float.Parse(txtSecondNum.Text);

            if (cbOperator.Text.ToString().Equals("+"))
            {
                txtAnswer.Text = BasicComputationn.Addition(Num1, Num2).ToString();
                
            }
            else if (cbOperator.Text.ToString().Equals("-"))
            {
                txtAnswer.Text = BasicComputationn.Subtraction(Num1, Num2).ToString();
            }
            else if (cbOperator.Text.ToString().Equals("*"))
            {
                txtAnswer.Text = BasicComputationn.Multiplication(Num1, Num2).ToString();
            }
            else if (cbOperator.Text.ToString().Equals("/"))
            {
                txtAnswer.Text = BasicComputationn.Division(Num1, Num2).ToString();
            }
            else
            {
                MessageBox.Show("Please select an output");
            }
        }
    }
}
