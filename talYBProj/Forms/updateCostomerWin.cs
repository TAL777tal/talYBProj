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
    public partial class updateCostomerWin : Form
    {
        dbEntities db = new dbEntities();
        List<costomerTBL> lst;
        public updateCostomerWin()
        {
            InitializeComponent();
        }

        private void kTBXEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void kBtnUpdate_Click(object sender, EventArgs e)
        {
            costomerTBL old = (costomerTBL)kCBXchose.SelectedItem;
            costomerTBL toUpdate = (from s in db.costomerTBL where s.Id == old.Id select s).FirstOrDefault();
            if (toUpdate == null)
            {
                return;
            }
            int idx = kCBXchose.SelectedIndex;
            toUpdate.firstName = kTBXFirstName.Text.Trim();
            toUpdate.lastName = kTBXLastName.Text.Trim();
            toUpdate.companyName = kTBXCompanyName.Text.Trim();
            toUpdate.address = kTBXAddress.Text.Trim();
            toUpdate.cellPhone = MTBphone1.Text.Trim();
            toUpdate.phone1 = MTBphone2.Text.Trim();
            toUpdate.officePhone = MTBOfficephone.Text.Trim();
            toUpdate.address = kTBXEmail.Text.Trim();
            toUpdate.price = Convert.ToDouble(MTBXprice.Text.Trim());
            toUpdate.notes = kRTBXNotes.Text.Trim();
            toUpdate = DBhelper.addCostomer(toUpdate);

        }

        private void kCBXchose_SelectedIndexChanged(object sender, EventArgs e)
        {
            costomerTBL selected = (costomerTBL)kCBXchose.SelectedItem;
            if(selected == null) 
            {
                return;
            }
            kTBXFirstName.Text = selected.firstName;
            kTBXLastName.Text = selected.lastName;
            kTBXCompanyName.Text = selected.companyName;
            kTBXAddress.Text = selected.address;
            MTBphone1.Text = selected.cellPhone;
            MTBphone2.Text = selected.phone1;
            MTBOfficephone.Text = selected.officePhone;
            kTBXEmail.Text = selected.email;
            MTBXprice.Text = Convert.ToString(selected.price);
            if (selected.notes != null)
                kRTBXNotes.Text = selected.notes;

        }

        private void kLabelChose_Click(object sender, EventArgs e)
        {

        }
    }
}
