using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
    public partial class orderReport : Form
    {
        dbEntities db = new dbEntities();
        List<orderView> orderlist;
        public orderReport()
        {
            InitializeComponent();
        }

        private void orderReport_Load(object sender, EventArgs e)
        {
            Orderlist = DBhelper.orderList;
            this.reportViewer1.RefreshReport();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ReportDataSource rdc = new ReportDataSource( "dsOrders" , Orderlist);
            reportViewer1.LocalReport.ReportPath = "orderReport.cs";
            reportViewer1.LocalReport.DataSources.Add(rdc);
            reportViewer1.Refresh();
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            orderlist = (from s in db.orderView select s).ToList();
        }
    }
}
