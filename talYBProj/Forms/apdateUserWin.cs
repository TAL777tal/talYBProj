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
    public partial class apdateUserWin : Form
    {
        List<userTBL> lst;
        public apdateUserWin()
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
            toUpdate.firstName = TBXfirstName.Text;
            toUpdate.lastName = TBXlastName.Text;
            toUpdate.email = TBXgmail.Text;
            toUpdate.cellPhone = MTXphoneNumber.Text;
            if (DBhelper.updateUser(toUpdate))
            {
                MessageBox.Show("add succefuly");
                updateCBX();
            }
            else //error
            {
                MessageBox.Show("error");

            }
        }
            private void updateCBX()
            {
                lst = DBhelper.userList;
                chooseCBX.DataSource = lst;
            }
        
    }
}
