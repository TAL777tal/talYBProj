using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace talYBProj.Forms
{
    public partial class editDolevWin : Form
    {
        List<costomerTBL> custList;
        List<userTBL> userList;
        public editDolevWin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            packTBL toUpdate = (packTBL)cbxchose.SelectedItem;
            if (toUpdate == null)
            {
                return;
            }
            int idx = cbxchose.SelectedIndex;
            userTBL selectedUser = (userTBL)cbxUserName.SelectedItem;
            orderTBL selectedOrder = (orderTBL)cbxOrderId.SelectedItem;
            toUpdate.userID = selectedUser.Id ;
            toUpdate.orderID = selectedOrder.Id;
            toUpdate.notes = txbNotes.Text.Trim();
            toUpdate.weight = (int)numericUpDownBruto.Value;
            //toUpdate.dolevNum = cbxDolevNum;
            netoValue.Value = ((int)numericUpDownBruto.Value - 40);

        }

        private void cbxchose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
