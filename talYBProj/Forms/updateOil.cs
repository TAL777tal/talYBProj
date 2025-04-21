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
    public partial class updateOil : Form
    {
        List<packTBL> packList;
        List<userTBL> userList;
        List<orderTBL> orderList;
        List<oilTBL> olives;
        public updateOil()
        {
            InitializeComponent();
        }

        private void cbxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateOil_Load(object sender, EventArgs e)
        {
            orderList = DBhelper.orderList.Where(x => !x.isDone).ToList();
            cbxOrder.DataSource = orderList;
        }
        private void updateDGV()
        {
            dgvOil.DataSource = cbxOil.DataSource = olives;
        }

        private void cbxOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            oilTBL selectedOil = (oilTBL)cbxOil.SelectedItem;
            apdateQuantity.Enabled = selectedOil != null;
            if (selectedOil == null)
            {
                kNUDquantity.Value = 0;
            }
            else
            {
                kNUDquantity.Value = selectedOil.quantity;
            }
        }

        private void apdateQuantity_Click(object sender, EventArgs e)
        {
            oilTBL selectedOil = (oilTBL)cbxOil.SelectedItem;
            selectedOil.quantity = (int)kNUDquantity.Value;
            selectedOil.currDate = DateTime.Now;
            if (DBhelper.updateOil(selectedOil))
            {
                MessageBox.Show("עודכן בהצלחה");
                cbxOil_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
