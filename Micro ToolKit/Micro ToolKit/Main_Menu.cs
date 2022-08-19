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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void btn_Convertor_Click(object sender, EventArgs e)
        {
            Convertor conv = new Convertor();
            conv.Show();
        }

        private void btn_Note_Click(object sender, EventArgs e)
        {
            Note_Taker no = new Note_Taker();
            no.Show();

        }

        private void btn_Reminder_Click(object sender, EventArgs e)
        {
                   }

        private void btn_Calander_Click(object sender, EventArgs e)
        {
            Calander cd = new Calander();
            cd.Show();
        }

        private void btn_Clock_Click(object sender, EventArgs e)
        {
            Analog an = new Analog();
            an.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About_Page ab = new About_Page();
            ab.Show();
        }
    }
}
