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
            bool isValidFirstName = Utils.validateName(kTBXFN.Text.Trim(), kTBXFN.TextBox, ep, "שם פרטי לא תקין.");
            bool isValidLastName = Utils.validateName(kTBXLN.Text.Trim(), kTBXLN.TextBox, ep, "שם משפחה לא תקין.");
            bool isValidCompanyName = Utils.validateName(kTBXCN.Text.Trim(), kTBXCN.TextBox, ep, "שם החברה לא תקין");
            bool isValidAddress = Utils.validateName(kTBXADD.Text.Trim(), kTBXADD.TextBox, ep, "כתובת לא תקינה");
            bool isValidCellPhone = Utils.validatePhoneNumber(MTBXPFirst.Text, MTBXPFirst, ep, "טלפון לא תקין");
            bool isValidphone1 = Utils.validatePhoneNumber(MTBXPSecend.Text, MTBXPSecend, ep, "טלפון לא תקין");
            bool isValidofficePhone = Utils.validatePhoneNumber(MTBXPOffice.Text, MTBXPOffice, ep, "טלפון לא תקין");
            bool isValidEmail = Utils.validateEmail(kTBXEmail.Text.Trim(), kTBXEmail.TextBox, ep, "אימייל לא תקין");
            if(isValidFirstName && isValidLastName && isValidCompanyName  && isValidAddress  && isValidCellPhone  && isValidphone1  && isValidofficePhone && isValidEmail)
            {
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
                    Utils.DBErrorMessage();
                }
                else
                {
                    Utils.addSuccessMessage();
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
           

        }

        private void kTBXFN_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerWin_Load(object sender, EventArgs e)
        {

        }

        private void addPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
