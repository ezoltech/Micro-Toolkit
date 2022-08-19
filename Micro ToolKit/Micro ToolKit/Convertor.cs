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
    public partial class Convertor : Form
    {
        Double Celicius, Fahrenit, Kelvin, Kilogram, Gram, Liter, Mililiter, Kilometer, Meter, Centimeter;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Op = "K";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Op = "GK";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Op = "KG";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Op = "LM";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            Op = "ML";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Op = "KM";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Op = "MK";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Op = "MC";

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Op = "CM";
        }

        
        private void btn_convert_Click(object sender, EventArgs e)
           {
            if(txt_amount.Text == txt_amount.Text) { 
            if(Op == "CF")
            {
                Celicius = double.Parse(txt_amount.Text);
                lbl_Convert.Text = ((((9 * Celicius)) / 5) + 9).ToString();
            }
           else if (Op == "FC")
            {
                Fahrenit = double.Parse(txt_amount.Text);
                lbl_Convert.Text = ((((Fahrenit - 32)) * 5) / 9).ToString();
            }
           else  if (Op == "K")
            {
                Kelvin = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (((((9 * Kelvin)) / 5) + 32) + 273.15).ToString();
            }
           else if (Op == "GK")
            {
                Kilogram = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Kilogram * 1000).ToString();
            }
            else if (Op == "KG")
            {
                Gram = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Gram / 1000).ToString();
            }
            else if (Op == "LM")
            {
                Liter = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Liter / 1000).ToString();
            }
            else if (Op == "ML")
            {
                Mililiter = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Mililiter * 1000).ToString();
            }
            else if (Op == "KM")
            {
                Kilometer = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Kilometer * 1000).ToString();
            }
            else if (Op == "MK")
            {
                Meter = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Meter / 1000).ToString();
            }
           else if (Op == "MC")
            {
                Meter = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Meter * 100).ToString();
            }
            else if (Op == "CM")
            {
                Centimeter = double.Parse(txt_amount.Text);
                lbl_Convert.Text = (Centimeter / 100).ToString();
            }
            else
            {

            }
           }
            else
            {
               MessageBox.Show("Enter a Number to Continue");
            }


        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_amount.Clear();
            lbl_Convert.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
           

        }

        private void btn_tomainmenu_Click(object sender, EventArgs e)
        {
            
        }
        string b;

        private void btn_cnv_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_amnt.Text);
            
                if (from_comboBox.SelectedItem == "Dollar" && to_comboBox.SelectedItem == "Birr")
                {
                    double conver = a * 52;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Birr" && to_comboBox.SelectedItem == "Dollar")
                {
                    double conver = a / 52.58;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Euro" && to_comboBox.SelectedItem == "Birr")
                {
                    double conver = a * 53.98;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Birr" && to_comboBox.SelectedItem == "Euro")
                {
                    double conver = a / 53.98;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Yuan" && to_comboBox.SelectedItem == "Birr")
                {
                    double conver = a * 7.77;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Birr" && to_comboBox.SelectedItem == "Yuan")
                {
                    double conver = a / 7.77;
                    lbl_final.Text = "Converted Amount\t" + " " + conver;
                }
                else if (from_comboBox.SelectedItem == "Dollar" && to_comboBox.SelectedItem == "Euro")
                {
                    double conver = a * 1.03;
                    lbl_final.Text = "Converted Amount" + conver;
                }
                else if (from_comboBox.SelectedItem == "Euro" && to_comboBox.SelectedItem == "Dollar")
                {
                    double conver = a / 1.03;
                    lbl_final.Text = "Converted Amount" + conver;
                }
                else if (from_comboBox.SelectedItem == "Dollar " && to_comboBox.SelectedItem == "Yuan")
                {
                    double conver = a * 52;
                    lbl_final.Text = "Converted Amount" + conver;
                }

                
            
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Op = "FC";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Op = "CF";
        }

        String Op;
        public Convertor()
        {
            InitializeComponent();
        }

        private void onlineConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void offlineConvertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Convertor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
