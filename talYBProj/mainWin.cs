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
using talYBProj.Forms.reportForms;
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
            current = new addOil();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
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

        private void BtnOpenCostomerListWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is costomerListWin)
                {
                    return;
                }
                current.Close();
            }
            current = new costomerListWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void btnOpenAddOrderWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addOrderWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addOrderWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
        private void btnOpenUpdateOrderWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateOrderWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateOrderWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton3_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is orderListWin)
                {
                    return;
                }
                current.Close();
            }
            current = new orderListWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton1_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateDolevWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateDolevWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton6_Click(object sender, EventArgs e)
        {

            if (current != null)
            {
                if (current is addZanWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addZanWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton7_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateZanWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateZanWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton8_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is zanListWin)
                {
                    return;
                }
                current.Close();
            }
            current = new zanListWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void btnOpenDolevWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is editDolevWin)
                {
                    return;
                }
                current.Close();
            }
            current = new editDolevWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton5_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is dolevsListWin)
                {
                    return;
                }
                current.Close();
            }
            current = new dolevsListWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton11_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is packList)
                {
                    return;
                }
                current.Close();
            }
            current = new packList();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void addClick_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addPack)
                {
                    return;
                }
                current.Close();
            }
            current = new addPack();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void updateClick_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updatePack)
                {
                    return;
                }
                current.Close();
            }
            current = new updatePack();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addUserWin)
                {
                    return;
                }
                current.Close();
            }
            current = new addUserWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateUserWin)
                {
                    return;
                }
                current.Close();
            }
            current = new updateUserWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void userList_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is userListWin)
                {
                    return;
                }
                current.Close();
            }
            current = new userListWin();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton4_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is addOil)
                {
                    return;
                }
                current.Close();
            }
            current = new addOil();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton9_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is updateOil)
                {
                    return;
                }
                current.Close();
            }
            current = new updateOil();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton10_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is oilList)
                {
                    return;
                }
                current.Close();
            }
            current = new oilList();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void mainWin_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonRibbon1_SelectedTabChanged(object sender, EventArgs e)
        {

        }

        private void kryptonRibbonGroupButton11_Click_1(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is orderReport)
                {
                    return;
                }
                current.Close();
            }
            current = new orderReport();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }

        private void kryptonRibbonGroupButton12_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is costomerReport)
                {
                    return;
                }
                current.Close();
            }
            current = new costomerReport();
            current.Dock = DockStyle.Fill;
            current.TopLevel = false;
            current.TopMost = true;
            mainPanel.Controls.Add(current);
            current.Show();
        }
    }
    
    
}
