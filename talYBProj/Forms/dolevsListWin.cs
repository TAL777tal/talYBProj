using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using talYBProj.IFS;

namespace talYBProj.Forms
{
    public partial class dolevsListWin : Form
    {
        List<oliveTBL> list;
        public dolevsListWin()
        {
            InitializeComponent();
        }

        private void dolevsListWin_Load(object sender, EventArgs e)
        {
            list = DBhelper.oliveList;
            dataGridView1.DataSource = list;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
