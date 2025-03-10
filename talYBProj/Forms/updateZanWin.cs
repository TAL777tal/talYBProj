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
    public partial class updateZanWin : Form
    {
        List<zanTBL> lst;
        public updateZanWin()
        {
            InitializeComponent();
        }

        private void apdateBtn_Click(object sender, EventArgs e)
        {
            zanTBL toUpdate = (zanTBL)cbxZanName.SelectedItem;
            toUpdate.name = cbxZanName.Text;
            toUpdate.description = tbxDes.Text.Trim();
            if (toUpdate == null)
            {
                return;
            }
            int idx = cbxZanName.SelectedIndex;
            if (DBhelper.updateZan(toUpdate))
            {
                MessageBox.Show("add succefuly");
                updateCBX();
            }
            else //error
            {
                MessageBox.Show("error");

            }
        }

        private void cbxZanName_SelectedIndexChanged(object sender, EventArgs e)
        {
            zanTBL selected = (zanTBL)cbxZanName.SelectedItem;
            if (selected == null)
            {
                return;
            }
            if (selected.description != null)
                tbxDes.Text = selected.description;

        }
        private void updateCBX()
        {
            lst = DBhelper.zanList;
            cbxZanName.DataSource = lst;
        }

        private void updateZanWin_Load(object sender, EventArgs e)
        {
            updateCBX();
        }

        private void cbxZanName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            zanTBL selected = (zanTBL)cbxZanName.SelectedItem;
            if (selected == null)
            {
                return;
            }
            if (selected.description != null)
                tbxDes.Text = selected.description;

        }
    }
}
