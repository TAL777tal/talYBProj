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
        public costomerReport()
        {
            InitializeComponent();
        }

        private void costomerReport_Load(object sender, EventArgs e)
        {
            costomerlist = DBhelper.customerViewsList;
            double totalPrice = costomerlist.Where(x => x.Id == 1 && !x.isDone).Select(x => x.price).Sum();
            double totalPacks = costomerlist.Where(x => x.Id == 1 && !x.isDone).Select(x => (double)x.totalPackPrice).Sum();
            MessageBox.Show("total = " + (totalPacks + totalPrice));
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
    }
}
