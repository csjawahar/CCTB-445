
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindSystem.Entities.POCOS;
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;

namespace DesktopApp.Reoprts
{
    public partial class ProductSalesForm : Form
    {
        public ProductSalesForm()
        {
            InitializeComponent();
        }

        private void ProductSalesForm_Load(object sender, EventArgs e)
        {
            List<ProductSaleSummary> list = new NorthwindManager().GetProductSaleSummaries();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource = "DesktopApp.Reoprts.ProductSalesReport.rdlc";

            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("ProductSalesDataset", list);
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

      
    }
}
