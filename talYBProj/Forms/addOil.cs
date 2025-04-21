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
    public partial class addOil : Form
    {
        List<packTBL> packList;
        List<userTBL> userList;
        List<orderTBL> orderList;
        public addOil()
        {
            InitializeComponent();
        }

        private void addOil_Load(object sender, EventArgs e)
        {
            packList = DBhelper.packList;
            userList = DBhelper.userList;
            orderList = DBhelper.orderList;
            packCBX.DataSource = packList;
            userCBX.DataSource = userList;
            orderCBX.DataSource = orderList;
        }

        private void rTBXpackDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void packCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packCBX != null)
            {
                packTBL selectedPack = (packTBL)packCBX.SelectedItem;
                rTBXpackDes.Text = selectedPack.notes.Trim();
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            packTBL selectedPack = (packTBL)packCBX.SelectedItem;
            userTBL selectedUser = (userTBL)userCBX.SelectedItem;
            orderTBL selectedOrder = (orderTBL)orderCBX.SelectedItem;
            oilTBL o1 = new oilTBL();
            o1.orderID = selectedOrder.Id;
            o1.PackID = selectedPack.Id;
            o1.userID = selectedUser.Id;
            o1.quantity = (int)NUPquantity.Value;
            o1.currDate = DateTime.Now;
            o1.notes = rTBXnotes.Text.Trim();
            o1 = DBhelper.addOil(o1);
            if (o1 == null)
            {
                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("OK");
                o1.notes = "";
            }
        }
    }
}
