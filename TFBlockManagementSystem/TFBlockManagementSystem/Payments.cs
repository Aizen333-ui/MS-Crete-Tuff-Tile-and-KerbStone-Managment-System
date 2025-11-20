using System;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public partial class Payments : UserControl
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtAmount.Text == "" || txtReason.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Warning");
                return;
            }

            dataGridView1.Rows.Add(
                txtID.Text,
                txtAmount.Text,
                txtReason.Text,
                datePaid.Value.ToShortDateString()
            );

            txtID.Clear();
            txtAmount.Clear();
            txtReason.Clear();
        }
    }
}
