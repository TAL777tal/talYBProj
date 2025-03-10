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
    public partial class orderListWin : Form
    {
        List<orderTBL> list;
        public orderListWin()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list = DBhelper.orderList;
            dataGridView2.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderListWin_Load(object sender, EventArgs e)
        {
            list = DBhelper.orderList;
            dataGridView2.DataSource = list;
        }
    }
}
