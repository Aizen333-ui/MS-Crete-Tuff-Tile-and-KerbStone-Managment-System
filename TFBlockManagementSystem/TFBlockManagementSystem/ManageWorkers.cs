using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class ManageWorkers : Form
    {
        private List<WorkerItem> workers;

        public ManageWorkers(List<WorkerItem> workers)
        {
            InitializeComponent();
            this.workers = workers;
            UpdateWorkerList();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            // Validate Worker ID
            if (!int.TryParse(txtWorkerID.Text.Trim(), out int id) || id <= 0)
            {
                MessageBox.Show("Worker ID must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get Worker Name
            string name = txtWorkerName.Text.Trim();

            // Validate Name
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Worker Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate ID
            if (workers.Exists(w => w.ID == id))
            {
                MessageBox.Show("Worker ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add new worker
            workers.Add(new WorkerItem(id, name));
            MessageBox.Show("Worker added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
            UpdateWorkerList();
        }


        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtWorkerID.Text.Trim(), out int id))
            {
                MessageBox.Show("Worker ID must be a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WorkerItem worker = workers.Find(w => w.ID == id);
            if (worker == null)
            {
                MessageBox.Show("Worker not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            workers.Remove(worker);
            MessageBox.Show("Worker removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputs();
            UpdateWorkerList();
        }

        private void UpdateWorkerList()
        {
            lstWorkers.Items.Clear();
            if (workers.Count == 0)
                lstWorkers.Items.Add("No workers available.");
            else
                foreach (var w in workers)
                    lstWorkers.Items.Add(w.ToString());
        }

        private void ClearInputs()
        {
            txtWorkerID.Clear();
            txtWorkerName.Clear();
        }
    }
}
