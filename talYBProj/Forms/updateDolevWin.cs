﻿using System;
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
        List<orderTBL> orderList;
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
            oliveTBL o1 = new oliveTBL();
            int count = 1;
           // while (count != selectedOrder.numOfDolevim + 1  || DBhelper.packList)
            //{
            //באיזה דולב צריך לטפל עכשיו
            // }
            o1.weightBruto = ((int)numericUpDownBruto.Value);
            o1.orderID = selectedOrder.Id;
            o1.userID = selectedUser.Id;
            o1.notes = txbNotes.Text.Trim();
            o1.currDate = DateTime.Now;
            o1.weightNeto = ((int)numericUpDownBruto.Value-40);
            o1 = DBhelper.addOlive(o1);
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

        private void updateDolevWin_Load(object sender, EventArgs e)
        {
            orderList = DBhelper.orderList;
            userList = DBhelper.userList;
            cbxUserName.DataSource = userList;
            cbxOrderId.DataSource = orderList;
        }
    }
}
