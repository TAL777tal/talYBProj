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
    public partial class userListWin : Form
    {
        List<userTBL> list;
        public userListWin()
        {
            InitializeComponent();
        }
        private void userList_Load(object sender, EventArgs e)
        {
            list = DBhelper.userList;
            dataGrdView1.DataSource = list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
