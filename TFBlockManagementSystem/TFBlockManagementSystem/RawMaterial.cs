using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TFBlockManagementSystem
{
    public partial class RawMaterial : UserControl
    {
        public RawMaterial()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || txtQty.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Warning");
                return;
            }

            dataGridView1.Rows.Add(txtID.Text, txtName.Text, txtQty.Text, dateAdded.Value.ToShortDateString());

            txtID.Clear();
            txtName.Clear();
            txtQty.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Select row to remove!");
            }
        }
    }
}
