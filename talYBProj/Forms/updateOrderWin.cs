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
        public updateOrderWin()
        {
            InitializeComponent();
        }

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderTBL selected = (orderTBL)cbxOrders.SelectedItem;
            if (selected != null)
            {
                return;
            }
           
            numericUpDownDolevim.Value = selected.numOfDolevim;
            if (selected.notes != null)
                kRTBXnotes.Text = selected.notes;

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            orderTBL toUpdate = (orderTBL)cbxOrders.SelectedItem;

            if (toUpdate == null)
            {
                return;
            }
            int idx = cbxOrders.SelectedIndex;
            toUpdate.notes = kRTBXnotes.Text.Trim();
            toUpdate.numOfDolevim = Convert.ToInt32(numericUpDownDolevim.Value);
            if (DBhelper.updateOrder(toUpdate))
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
            lst = DBhelper.orderList;
            cbxOrders.DataSource = lst;
        }

        private void updateOrder_Load(object sender, EventArgs e)
        {
            updateCBX();
        }
    }    
}
