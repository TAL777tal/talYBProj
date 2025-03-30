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
    public partial class updateUserWin : Form
    {
        List<userTBL> lst;
        public updateUserWin()
        {
            InitializeComponent();
        }

        private void chooseCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTBL selected = (userTBL)chooseCBX.SelectedItem;
            if (selected == null)
            {
                return;
            }
            TBXfirstName.Text = selected.firstName;
            TBXlastName.Text = selected.lastName;
            TBXgmail.Text = selected.email;
            MTXphoneNumber.Text = selected.cellPhone;
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            userTBL toUpdate = (userTBL)chooseCBX.SelectedItem;
            if (toUpdate == null)
            {
                return;
            }
            bool isValidFirstName = Utils.validateName(TBXfirstName.Text, TBXfirstName.TextBox, ep, "שם לא תקין");
            bool isValidLastName = Utils.validateName(TBXlastName.Text, TBXlastName.TextBox, ep, "שם לא תקין");
            bool isValidEmail = Utils.validateEmail(TBXgmail.Text, TBXgmail.TextBox, ep, "אימייל לא תקין");
            bool isValidCellPhone = Utils.validatePhoneNumber(MTXphoneNumber.Text, MTXphoneNumber, ep, "מספר לא תקין");
            if (isValidFirstName && isValidLastName && isValidEmail && isValidCellPhone)
            {
                int idx = chooseCBX.SelectedIndex;
                toUpdate.firstName = TBXfirstName.Text;
                toUpdate.lastName = TBXlastName.Text;
                toUpdate.email = TBXgmail.Text;
                toUpdate.cellPhone = MTXphoneNumber.Text;
                if (DBhelper.updateUser(toUpdate))
                {
                    MessageBox.Show("add successfuly");
                    updateCBX();
                }
                else //error
                {
                    MessageBox.Show("error");

                }
            }
        }
            private void updateCBX()
            {
                lst = DBhelper.userList;
                chooseCBX.DataSource = lst;
            }

        private void chooseCBX_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            userTBL selected = (userTBL)chooseCBX.SelectedItem;
            if (selected == null)
            {
                return;
            }
            TBXfirstName.Text = selected.firstName;
            TBXlastName.Text = selected.lastName;
            TBXgmail.Text = selected.email;
            MTXphoneNumber.Text = selected.cellPhone;
        }

        private void apdateUserWin_Load(object sender, EventArgs e)
        {
            updateCBX();
        }
    }
}
