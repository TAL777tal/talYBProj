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
    public partial class addZanWin : Form
    {
        List<zanTBL> zanList;
        public addZanWin()
        {
            InitializeComponent();
        }

        private void addZanWin_Load(object sender, EventArgs e)
        {

        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            zanTBL z1 = new zanTBL();
            bool isValidName = Utils.validateName(tbxZan.Text , tbxZan.TextBox , ep , "שם לא תקין");
            if (isValidName)
            {
                z1.name = tbxZan.Text;
                z1.description = tbxDes.Text.Trim();
                z1 = DBhelper.addZan(z1);
                if (z1 == null)
                {
                    MessageBox.Show("arror");
                }
                else
                {
                    MessageBox.Show("add succeccfuly");
                }
            }
        }
    }
}
