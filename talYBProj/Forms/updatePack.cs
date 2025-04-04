﻿using System;
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
    public partial class updatePack : Form
    {
        List<packTBL> lst;
        public updatePack()
        {
            InitializeComponent();
        }

        private void weightCBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void updateCBX()
        {
            lst = DBhelper.packList;
            choseCBX.DataSource = lst;
        }

        private void apdateButton_Click(object sender, EventArgs e)
        {
            packTBL toUpdate = (packTBL)choseCBX.SelectedItem;        
            if (toUpdate == null)
            {
                return;
            }
            int idx = choseCBX.SelectedIndex;
            toUpdate.weight = (int)CBXweight.Value;
            toUpdate.price = (int)((int)CBXweight.Value * 2);
            toUpdate.packName = nameTBX.Text;
            toUpdate.notes = notesTBX.Text.Trim();
            if (DBhelper.updatePack(toUpdate))
            {
                MessageBox.Show("add succefuly");
                updateCBX();
            }
            else //error
            {
                MessageBox.Show("error");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            packTBL selected = (packTBL)choseCBX.SelectedItem;
            if (selected == null)
            {
                return;
            }
            CBXweight.Value = selected.weight;
            nameTBX.Text = selected.packName;
            if (selected.notes != null)
                notesTBX.Text = selected.notes; 

        }

        private void updatePack_Load(object sender, EventArgs e)
        {
            updateCBX();
        }

        private void CBXweight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
