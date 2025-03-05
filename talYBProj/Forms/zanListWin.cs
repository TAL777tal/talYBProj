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
    public partial class zanListWin : Form
    {
        List<zanTBL> list;

        public zanListWin()
        {
            InitializeComponent();
        }
        private void zanList_Load(object sender, EventArgs e)
        {
            list = DBhelper.zanList;
            dtGridView1.DataSource = list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
