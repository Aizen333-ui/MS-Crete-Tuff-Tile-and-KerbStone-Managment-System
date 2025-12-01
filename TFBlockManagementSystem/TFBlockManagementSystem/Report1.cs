using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Factory1_Dashboard.Pages
{
    public partial class Report1 : UserControl
    {
        public Report1()
        {
            InitializeComponent();
            btnGenerate.Click += BtnGenerate_Click;
        }

        private void BtnGenerate_Click(object? sender, EventArgs e)
        {
            DateTime from = dateFrom.Value.Date;
            DateTime to = dateTo.Value.Date;

            DataTable dt = new DataTable();
            dt.Columns.Add("Type");
            dt.Columns.Add("Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Unit");
            dt.Columns.Add("Date");

            // Raw Material Filtered Data
            var rawList = GlobalStorage.RawMaterials
                .Where(x => x.Date.Date >= from && x.Date.Date <= to)
                .ToList();

            foreach (var r in rawList)
            {
                dt.Rows.Add(
                    "Raw Material",
                    r.MaterialName,
                    r.Quantity,
                    r.Unit,            // ✅ Add Unit here
                    r.Date.ToShortDateString()  // ✅ Add Date
                );
            }

            // Production Filtered Data
            var prodList = GlobalStorage.Productions
                .Where(x => x.Date.Date >= from && x.Date.Date <= to)
                .ToList();

            foreach (var p in prodList)
            {
                dt.Rows.Add(
                    "Production",
                    p.ProductName,
                    p.Quantity,
                    p.Unit,
                    p.Date.ToShortDateString()
                );
            }

            dataGridReport.DataSource = dt;
        }
    }
}
