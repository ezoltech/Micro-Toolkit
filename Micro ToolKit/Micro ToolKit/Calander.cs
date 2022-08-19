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
    public partial class Calander : Form
    {
        public Calander()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if(txt_ask.Text == txt_ask.Text)
            {
                txt_ask.Text = monthCalendar1.SelectionStart.ToString();
            }
            else
            {
                MessageBox.Show("please select a valid date to continue");
            }
            
        }
    }
}
