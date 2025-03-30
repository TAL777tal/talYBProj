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
    public partial class addUserWin : Form
    {
        dbEntities db = new dbEntities();
        List<userTBL> lst;
        public addUserWin()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            userTBL u1 = new userTBL();
            bool isValidFirstName = Utils.validateName(TBXfirstName.Text, TBXfirstName.TextBox, ep, "שם לא תקין");
            bool isValidLastName = Utils.validateName(TBXlastName.Text, TBXlastName.TextBox, ep, "שם לא תקין");
            bool isValidEmail = Utils.validateEmail(TBXgmail.Text, TBXgmail.TextBox, ep, "אימייל לא תקין");
            bool isValidCellPhone = Utils.validatePhoneNumber(MTXphoneNumber.Text , MTXphoneNumber , ep , "מספר לא תקין");
            if (isValidFirstName && isValidLastName && isValidEmail && isValidCellPhone)
            {
                u1.firstName = TBXfirstName.Text;
                u1.lastName = TBXlastName.Text;
                u1.email = TBXgmail.Text;
                u1.cellPhone = MTXphoneNumber.Text;
                u1 = DBhelper.addUser(u1);
                if (u1 == null)
                {
                    MessageBox.Show("error");
                }
                else
                {
                    MessageBox.Show("OK");
                }
            }
        }

        private void addUserWin_Load(object sender, EventArgs e)
        {

        }
    }
}
