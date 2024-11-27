using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using talYBProj.Forms;
using talYBProj.IFS;

namespace talYBProj
{
    public partial class mainWin : Form
    {
        Form current;
        public mainWin()
        {
            InitializeComponent();
        }



        private void mainWin_Load(object sender, EventArgs e)
        {
            current = null;
            DBhelper.init();
        }

        private void btnOpenCustWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addCustomerWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addCustomerWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton2_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateCostomerWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateCostomerWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
    }
}
