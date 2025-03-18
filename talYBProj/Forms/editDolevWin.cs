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
    public partial class editDolevWin : Form
    {
        List<userTBL> userList;
        List<oliveTBL> lst;
        List<orderTBL> orderList;
        public editDolevWin()
        {
            InitializeComponent();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            oliveTBL toUpdate = null;
            if (toUpdate == null)
            {
                return;
            }
            toUpdate.dolevNum = (int)dolevNumb.Value;
            toUpdate.currDate = dateTimeP.Value;
            toUpdate.weightBruto = (int)numericUpDownBruto.Value;
            toUpdate.weightNeto = toUpdate.weightBruto - 40;
            userTBL chooseUser = (userTBL)cbxUserName.SelectedItem;
            toUpdate.userID = chooseUser.Id;
            toUpdate.notes = txbNotes.Text;
            toUpdate.orderDate = toUpdate.currDate;
            if (DBhelper.updateOlive(toUpdate))
            {
                MessageBox.Show("apdate successfuly");
                updateCBX();
            }
            else //error
            {
                MessageBox.Show("error");

            }
        }

            private void cbxchose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editDolevWin_Load(object sender, EventArgs e)
        {
            updateCBX();
        }
        private void updateCBX()
        {
            lst = DBhelper.oliveList;
            orderList = DBhelper.orderList;
            cbxOrderId.DataSource = orderList;
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            orderTBL selectedOrder = (orderTBL)cbxOrderId.SelectedItem;
            if (selectedOrder == null)
            {
                return;
            }
            int count = selectedOrder.numOfDolevim;
            if(dolevNumb.Value == count)
            {
                dolevNumb.Value = 1;
            }
            else
            {
                dolevNumb.Value++;
            }
        }

        private void dolevNumb_ValueChanged(object sender, EventArgs e)
        {
          //  userTBL chooseUser = (userTBL)cbxUserName.SelectedItem;
        //    orderTBL selectedOrder = (orderTBL)cbxOrderId.SelectedItem;
        //    int dolevnum = (int)dolevNumb.Value;
        //    List<oliveTBL> list = DBhelper.oliveList.Where(x => x.orderID == selectedOrder.Id  && x.dolevNum == (int)dolevNumb.Value).ToList();
       //     if (list.Count > 0)
       //     {
      //          dateTimeP.Value = list[0].currDate;
       //         numericUpDownBruto.Value = list[0].weightBruto;
       //         chooseUser.Id = list[0].userID;
        //        txbNotes.Text = list[0].notes;
      //      }
        //    else
         //   {
         //       MessageBox.Show("הכנס דולבים להזמנה");
            }
      //  }
    }
}
