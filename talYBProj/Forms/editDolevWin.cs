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
        List<orderTBL> orderList;
        List<oliveTBL> olives;
        public editDolevWin()
        {
            InitializeComponent();
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

            orderList = DBhelper.orderList.Where(x => !x.isDone).ToList();
            cbxOrderId.DataSource = orderList;
        }

        private void cbxOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderTBL selectedOrder = (orderTBL)cbxOrderId.SelectedItem;
            if (selectedOrder == null)
            {
                olives = new List<oliveTBL>();

            }
            else
            {
                olives = DBhelper.oliveList.Where(x => x.orderID == selectedOrder.Id).ToList();

            }
            updateDGV();
        }

        private void updateDGV()
        {
            dgvOlives.DataSource = cbxOlives.DataSource = olives;
        }

        private void cbxOlives_SelectedIndexChanged(object sender, EventArgs e)
        {
            oliveTBL selectedOlive = (oliveTBL)cbxOlives.SelectedItem;
            btnUpdate.Enabled = selectedOlive != null;
            if (selectedOlive == null)
            {
               nupEditDolev.Value = 0;
            }
            else
            {
                nupEditDolev.Value = selectedOlive.weightBruto;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oliveTBL selectedOlive = (oliveTBL)cbxOlives.SelectedItem;
            int bruto = (int)nupEditDolev.Value;
            if (bruto <= 40)
            {
                /// error
                return;
            }
            selectedOlive.weightBruto = bruto;
            selectedOlive.weightNeto = bruto-40;
            selectedOlive.currDate = DateTime.Now;
            if (DBhelper.updateOlive(selectedOlive))
            {
                MessageBox.Show("עודכן בהצלחה");
                cbxOrderId_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dgvOlives_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
