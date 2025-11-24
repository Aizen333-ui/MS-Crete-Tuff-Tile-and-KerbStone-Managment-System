using System;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class OwnerReportsPage : UserControl
    {
        public OwnerReportsPage()
        {
            InitializeComponent();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            string factory = comboFactory.SelectedItem?.ToString();

            if (factory == null)
            {
                MessageBox.Show("Please select a factory.");
                return;
            }

            DateTime fromDate = dtFrom.Value;
            DateTime toDate = dtTo.Value;

            // --- FUTURE BACKEND LOGIC WILL COME HERE ---
            // Fetch data from Factory 1 & Factory 2 tables based on date range

            txtReport.Text =
                $"Report for {factory}\r\n" +
                $"Date Range: {fromDate.ToShortDateString()} to {toDate.ToShortDateString()}\r\n\r\n" +
                $"• Total Production: (sample data)\r\n" +
                $"• Raw Material Used: (sample data)\r\n" +
                $"• Workers Active: (sample data)\r\n" +
                $"• Payments: (sample data)\r\n\r\n" +
                $" Report generated successfully!";
        }
    }
}
