using Microsoft.Reporting.WinForms;
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

namespace talYBProj.Forms.reportForms
{
    public partial class costomerReport : Form
    {
        List<customerView> costomerlist;
        List<costomerNameView> lst;

        public costomerReport()
        {
            InitializeComponent();
        }

        private void costomerReport_Load(object sender, EventArgs e)
        {
            costomerlist = DBhelper.customerViewsList;
            lst = new List<costomerNameView>();
            var tmp = costomerlist.GroupBy(x => x.fullName).ToList();
            foreach (var ord in tmp)
            {
                costomerNameView toAdd = new costomerNameView();
                toAdd.fallName = ord.FirstOrDefault().fullName;
                toAdd.email = ord.FirstOrDefault().email;
                toAdd.price = (int) ord.Select(x => x.price).Sum();
                toAdd.totalPackPrice = (int)ord.Select(x => x.totalPackPrice).Sum();
                lst.Add(toAdd);
            }
            dgvCust.DataSource = lst;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void kbtnGenerate_Click(object sender, EventArgs e)
        {
            ReportDataSource rdc = new ReportDataSource("DScostom", costomerlist);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\talhe\\source\\repos\\talYBProj\\talYBProj\\Forms\\reportForms\\costomerReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rdc);
            this.reportViewer1.RefreshReport();
        }
        private class costomerNameView
        {
            public string fallName { get; set; }
            public string email { get; set; }
            public float price { get; set; }
            public float totalPackPrice { get; set; }
        }
    }
}
