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
    public partial class oilList : Form
    {
        List<oilTBL> list;

        public oilList()
        {
            InitializeComponent();
        }

        private void oilList_Load(object sender, EventArgs e)
        {
            list = DBhelper.oilList;
            dataGridView1.DataSource = list;
        }
    }
}
