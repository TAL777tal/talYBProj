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
    public partial class addOrderWin : Form
    {
        List<costomerTBL> custList;
        List<zanTBL> zanList;
        List<userTBL> userList;
        public addOrderWin()
        {
            InitializeComponent();
        }

        private void kryptonLabel10_Click(object sender, EventArgs e)
        {

        }

        private void addOrderWin_Load(object sender, EventArgs e)
        {
            custList = DBhelper.costomerList;
            zanList = DBhelper.zanList;
            userList = DBhelper.userList;
            cbxUsers.DataSource= userList;
            cbxCust.DataSource = custList;
            cbxZan.DataSource = zanList;
        }

        private void isDoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            

            // validations

            userTBL selectedUser = (userTBL) cbxUsers.SelectedItem  ;
            costomerTBL selectedCust = (costomerTBL) cbxCust.SelectedItem ;
            zanTBL selectedZan = (zanTBL) cbxZan.SelectedItem ;

            orderTBL o1 = new orderTBL();
            o1.userID = selectedUser.Id ;
            o1.zanID = selectedZan.Id ;
            o1.costomerID = selectedCust.Id ;
            o1.numOfDolevim = ((int)nUDnumOfDolevim.Value);
            o1.orderDate = DateTime.Now;
            o1.isDone = false;
            o1.isPayd = false ;
            o1.price = Convert.ToDouble(MTBprice.Text.Trim()); 
            o1.notes = TBXnotes.Text.Trim();
            o1 = DBhelper.addOrder(o1);
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

        private void cbxCust_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
