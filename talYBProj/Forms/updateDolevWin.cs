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
    public partial class updateDolevWin : Form
    {
        List<costomerTBL> custList;
        List<userTBL> userList;
        public updateDolevWin()
        {
            InitializeComponent();
        }

        private void kryptonLabel4_Click(object sender, EventArgs e)
        {

        }

        private void cbxNameCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cbxDolevNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            userTBL selectedUser = (userTBL)cbxUserName.SelectedItem;
            orderTBL selectedOrder = (orderTBL)cbxOrderId.SelectedItem;
            packTBL p1 = new packTBL();
            int count = 1;
           // while (count != selectedOrder.numOfDolevim + 1  || DBhelper.packList)
            //{
            //
           // }
            p1.weight = ((int)numericUpDownBruto.Value);
            p1.orderID = selectedOrder.Id;
            p1.userID = selectedUser.Id;
            p1.notes = txbNotes.Text.Trim();
            p1.date = DateTime.Now;
            netoValue.Value = ((int)numericUpDownBruto.Value-40);
            p1 = DBhelper.addPack(p1);
            if (p1 == null)
            {
                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("OK");
                p1.notes = "";

            }
        }
    }
}
