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
    public partial class costomerListWin : Form
    {
        List<costomerTBL> list;
        public costomerListWin()
        {
            InitializeComponent();
        }

        private void costomerList_Load(object sender, EventArgs e)
        {
            list = DBhelper.costomerList;
            dgvCust.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
