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
using talYBProj.dbDataSetTableAdapters;
using talYBProj.IFS;

namespace talYBProj.Forms
{
    public partial class orderReport : Form
    {      
        List<orderView> orderlist;
        public orderReport()
        {
            InitializeComponent();
        }


        private void orderReport_Load_1(object sender, EventArgs e)
        {
            orderlist = DBhelper.orderViewsList;
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            //orderlist = (from s in db.orderView select s).ToList();
        }

        private void kbtnGenerate_Click(object sender, EventArgs e)
        {
            ReportDataSource rdc = new ReportDataSource("DataSet1", orderlist);
            reportViewer2.LocalReport.DataSources.Clear();  
            reportViewer2.LocalReport.ReportPath = "C:\\Users\\talhe\\source\\repos\\talYBProj\\talYBProj\\Forms\\reportForms\\orderReport.rdlc";
            reportViewer2.LocalReport.DataSources.Add(rdc);
            this.reportViewer2.RefreshReport();
        }
    }
}
