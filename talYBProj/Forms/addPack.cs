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
            bool isValidPackName = Utils.validateName(nameTBX.Text.Trim(), nameTBX.TextBox, ep, "השם לא תקין");
            if (isValidPackName)
            {
                p1.packName = nameTBX.Text.Trim();
                p1.weight = (int)CBXweight.Value;
                p1.price = Convert.ToDouble(MTBprice.Text.Trim());
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

        private void addPack_Load(object sender, EventArgs e)
        {

        }
    }
}
