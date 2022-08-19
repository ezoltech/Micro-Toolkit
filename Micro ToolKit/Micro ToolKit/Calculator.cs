using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micro_ToolKit
{
    public partial class Calculator : Form
    {

        double valOne, valTwo;
        double result;
        String sign;
        bool op = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            op = true;
            sign = "*";
            txtResult.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = true;
            sign = "/";
            txtResult.Text = "";
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            cal.Show();
        }

        private void scientficToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void graphCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            GroupBox g = new GroupBox();
            Calculator.ActiveForm.Width = 300;
            txtResult.Width = 250;
            g.Show();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupBox gr = new GroupBox();
            Calculator.ActiveForm.Width = 411;
            txtResult.Width = 352;
            gr.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
            if (!op)
            {
                valOne = int.Parse(txtResult.Text);
            }
            else
            {
                valTwo = int.Parse(txtResult.Text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            op = true;
            sign = "+";
            txtResult.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            op = true;
            sign = "-";
            txtResult.Text = "";
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 1) {
                MessageBox.Show("Error!");
            }
            else
            txtResult.Text += ".";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
               
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            op = false;
            switch (sign)
            {
                case "+":
                    result = valOne + valTwo;
                    txtResult.Text = result.ToString();
                    break;
                case "-":
                    result = valOne - valTwo;
                    txtResult.Text = result.ToString();
                    break;
                case "*":
                    result = valOne * valTwo;
                    txtResult.Text = result.ToString();
                    break;
                case "/":
                    if (valTwo == 0)
                    {
                        MessageBox.Show("Unknown error!");
                        break;
                    }
                    result = valOne / valTwo;
                    txtResult.Text = result.ToString();
                    break;
                case "√":
                    
                    result = Math.Sqrt(valOne);
                    txtResult.Text = result.ToString();
                    break;
                default:
                    MessageBox.Show("Unknown error!");
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            txtResult.Text += "1";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            txtResult.Text += "2";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = null;
            txtResult.Text += "3";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
          
            txtResult.Text += "6";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            
            txtResult.Text += "0";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtResult.Text += "5";
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
           
            txtResult.Text += "4";
           
            if (!op)
            {
                valOne = double.Parse(txtResult.Text);
            }
            else
            {
                valTwo = double.Parse(txtResult.Text);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            op = true;
            sign = "+";
            txtResult.Text = "+";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtResult.Text, " ") < 0))
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1 + 1);
            }
            else
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            txtResult.Text = " ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtResult.Text, " ") < 0))
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1 + 1);
            }
            else
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Text += "-";
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
           // op = true;
           
            sign = "√";
            label1.Text = "√" ;
            
            

        
        }

        private void item2_Click(object sender, EventArgs e)
        {
            GroupBox gr = new GroupBox();
            Calculator.ActiveForm.Width = 391;
            txtResult.Width = 385;
            gr.Show();
        }

        private void standardToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            GroupBox g = new GroupBox();
            Calculator.ActiveForm.Width = 287;
            txtResult.Width = 250;
            g.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {

            op = true;
            sign = "(";
            txtResult.Text = "(";
        }

        private void btn_r_B_Click(object sender, EventArgs e)
        {

            op = true;
            sign = ")";
            txtResult.Text = ")";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {

        }
    }
}