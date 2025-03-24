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
    public partial class addCustomerWin : Form
    {
        dbEntities db = new dbEntities();
        List<costomerTBL> lst;
        public addCustomerWin()
        {
            InitializeComponent();
        }

        private void addCostumer_Click(object sender, EventArgs e)
        {
            costomerTBL c1 = new costomerTBL();
            c1.firstName = kTBXFN.Text.Trim();
            c1.lastName = kTBXLN.Text.Trim();
            c1.companyName = kTBXCN.Text.Trim();
            c1.address = kTBXADD.Text.Trim();
            c1.cellPhone = MTBXPFirst.Text.Trim();
            c1.phone1 = MTBXPSecend.Text.Trim();

            c1.officePhone = MTBXPOffice.Text.Trim();
            c1.email = kTBXEmail.Text.Trim();
            c1.price = Convert.ToDouble(kTBXPrice.Text.Trim());
            c1.notes = kRTBXN.Text.Trim();
            
            c1 = DBhelper.addCostomer(c1);
            if (c1 == null)
            {
                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("add successfuly");
                kTBXFN.Text = "";
                kTBXLN.Text = "";
                kTBXCN.Text = "";
                kTBXADD.Text = "";
                MTBXPFirst.Text = "";
                MTBXPSecend.Text = "";
                MTBXPOffice.Text = "";
                kTBXEmail.Text = "";
                kTBXPrice.Text = "";
                kRTBXN.Text = "";
            }

        }

        private void kTBXFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerWin_Load(object sender, EventArgs e)
        {

        }
    }
}
