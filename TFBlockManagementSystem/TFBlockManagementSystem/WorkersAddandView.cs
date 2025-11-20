using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TFBlockManagementSystem
{
    public partial class WorkersAddandView : UserControl
    {
        public WorkersAddandView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtRole.Text == "" || txtWage.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Warning");
                return;
            }

            dataGridView1.Rows.Add(
                txtName.Text,
                txtRole.Text,
                txtWage.Text + " PKR"
            );

            txtName.Clear();
            txtRole.Clear();
            txtWage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a worker to remove!");
                return;
            }

           
        }
    }
}
