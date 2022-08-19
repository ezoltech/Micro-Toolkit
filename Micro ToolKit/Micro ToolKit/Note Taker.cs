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
    public partial class Note_Taker : Form
    {
        public Note_Taker()
        {
            InitializeComponent();
        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {

        }
            DataTable  table;
        private void Note_Taker_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("table", typeof(String));
            table.Columns.Add("Body", typeof(String));
            dataGridView1.DataSource = table;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_title.Clear();
            txt_Body.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_title.Text, txt_Body);
            txt_title.Clear();
            txt_Body.Clear();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if(index > -1)
            {
                txt_title.Text = table.Rows[index].ItemArray[0].ToString();
                txt_Body.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}
