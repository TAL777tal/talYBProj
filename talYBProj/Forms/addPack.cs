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
    public partial class addPack : Form
    {
        public addPack()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            packTBL p1 = new packTBL();
            p1.packName = nameTBX.Text.Trim();
            p1.weight = CBXweight.SelectedIndex;
            if (CBXweight.SelectedIndex == 1)
            {
                p1.price = 5;
            }
            if (CBXweight.SelectedIndex == 2)
            {
                p1.price = 10;
            }
            if (CBXweight.SelectedIndex == 4)
            {
                p1.price = 20;
            }
            if (CBXweight.SelectedIndex == 5)
            {
                p1.price = 25;
            }
            if (CBXweight.SelectedIndex == 10)
            {
                p1.price = 50;
            }
            if (CBXweight.SelectedIndex == 15)
            {
                p1.price = 75;
            }
            if (CBXweight.SelectedIndex == 20)
            {
                p1.price = 100;
            }
            p1.notes = notesTBX.Text.Trim();
            p1 = DBhelper.addPack(p1);
            if (p1 == null)
            {
                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("OK");
            }
        }
    }
}
