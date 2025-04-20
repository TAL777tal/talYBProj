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
    public partial class orderReport : Form
    {
        List<orderTBL> Orderlst;
        public orderReport()
        {
            InitializeComponent();
        }

        private void orderReport_Load(object sender, EventArgs e)
        {
            Orderlst = DBhelper.orderList;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
