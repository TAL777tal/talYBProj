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
    public partial class packList : Form
    {
        List<packTBL> list;
        public packList()
        {
            InitializeComponent();
        }
        private void packList_Load(object sender, EventArgs e)
        {
            list = DBhelper.packList;
            dataGridVie1.DataSource = list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
