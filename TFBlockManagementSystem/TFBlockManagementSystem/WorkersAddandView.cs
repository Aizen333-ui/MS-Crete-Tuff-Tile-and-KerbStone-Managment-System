using System;
using System.IO;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class WorkersAddandView : Form
    {
        string filePath = @"Data/workers.txt";

        public WorkersAddandView()
        {
            InitializeComponent();
            Directory.CreateDirectory("Data");
        }

        private void ManageWorkers_Load(object sender, EventArgs e)
        {
            LoadWorkers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string role = textBoxRole.Text.Trim();
            string wage = textBoxWage.Text.Trim();

            if (name == "" || role == "" || wage == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string workerInfo = $"{name},{role},{wage}";
            File.AppendAllText(filePath, workerInfo + Environment.NewLine);
            LoadWorkers();

            textBoxName.Clear();
            textBoxRole.Clear();
            textBoxWage.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxWorkers.SelectedItem == null)
            {
                MessageBox.Show("Select a worker to remove.");
                return;
            }

            string selected = listBoxWorkers.SelectedItem.ToString();
            var lines = File.ReadAllLines(filePath);
            File.WriteAllLines(filePath, Array.FindAll(lines, line => line != selected));

            LoadWorkers();
        }

        private void LoadWorkers()
        {
            listBoxWorkers.Items.Clear();
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                    listBoxWorkers.Items.Add(line);
            }
        }
    }
}
