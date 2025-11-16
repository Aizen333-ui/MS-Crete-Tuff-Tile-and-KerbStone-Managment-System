using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Reports : Form
    {
        private List<WorkerItem> workers;
        private List<RawMaterialItem> rawMaterials;
        private List<PaymentItem> payments;

        public Reports(List<WorkerItem> workers, List<RawMaterialItem> rawMaterials, List<PaymentItem> payments)
        {
            InitializeComponent();
            this.workers = workers;
            this.rawMaterials = rawMaterials;
            this.payments = payments;
            LoadReports();
        }

        private void LoadReports()
        {
            lstWorkers.Items.Clear();
            foreach (var w in workers)
                lstWorkers.Items.Add(w.ToString());

            lstMaterials.Items.Clear();
            foreach (var m in rawMaterials)
                lstMaterials.Items.Add(m.ToString());

            lstPayments.Items.Clear();
            foreach (var p in payments)
                lstPayments.Items.Add(p.ToString());
        }
    }
}
