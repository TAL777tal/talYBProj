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
    public partial class updateOrderWin : Form
    {
        List<orderTBL> lst;
        List<costomerTBL> custList;
        List<zanTBL> zanList;
        List<userTBL> userList;
        public updateOrderWin()
        {
            InitializeComponent();
        }

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderTBL selected = (orderTBL)cbxOrders.SelectedItem;
            userTBL selectedUser = (userTBL)cbxUsers.SelectedItem;
            costomerTBL selectedCust = (costomerTBL)cbxCostumerName.SelectedItem;
            zanTBL selectedZan = (zanTBL)cbxOliveKind.SelectedItem;
            if (selected == null)
            {
                return;
            }
            //cbxUsers.SelectedIndex = selected.userID;
            //cbxCostumerName.SelectedIndex = selected.costomerID;
            //cbxOliveKind.SelectedIndex = selected.zanID;
            numericUpDownDolevim.Value = selected.numOfDolevim;
            MTBprice.Text = Convert.ToString(selected.price);
            if (selected.notes != null)
                kRTBXnotes.Text = selected.notes;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            orderTBL toUpdate = (orderTBL)cbxOrders.SelectedItem;
            userTBL selectedUser = (userTBL)cbxUsers.SelectedItem;
            costomerTBL selectedCust = (costomerTBL)cbxCostumerName.SelectedItem;
            zanTBL selectedZan = (zanTBL)cbxOliveKind.SelectedItem;
            if (toUpdate == null)
            {
                return;
            }
            int idx = cbxOrders.SelectedIndex;
            toUpdate.userID = selectedUser.Id;
            toUpdate.costomerID = selectedCust.Id;
            toUpdate.zanID = selectedZan.Id;
            toUpdate.notes = kRTBXnotes.Text.Trim();
            toUpdate.price = Convert.ToDouble(MTBprice.Text.Trim());
            toUpdate.numOfDolevim = Convert.ToInt32(numericUpDownDolevim.Value);
            if (DBhelper.updateOrder(toUpdate))
            {
                MessageBox.Show("apdate succefuly");
                updateCBX();
            }
            else //error
            {
                MessageBox.Show("error");

            }

        }
        private void updateCBX()
        {
            lst = DBhelper.orderList;
            cbxOrders.DataSource = lst;
        }

        private void updateOrder_Load(object sender, EventArgs e)
        {
            updateCBX();
            custList = DBhelper.costomerList;
            zanList = DBhelper.zanList;
            userList = DBhelper.userList;
            cbxUsers.DataSource = userList;
            cbxCostumerName.DataSource = custList;
            cbxOliveKind.DataSource = zanList;
        }

        private void cbxCostumerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }    
}
