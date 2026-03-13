using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TFBlockManagementSystem
{
    public static class RawMaterialDb
    {
        private static string connStr = @"Data Source=TALHA\SQLEXPRESS;Initial Catalog=MSBlockDB;Integrated Security=True;";


    // ----------------------------
    // REMOVE RAW MATERIAL BY NAME & QUANTITY FOR FACTORY 1 OR 2
    // ----------------------------
    public static bool RemoveQuantity(string materialName, int quantity, string factory)
        {
            if (string.IsNullOrEmpty(materialName))
            {
                MessageBox.Show("Material name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string tableName = factory switch
            {
                "Factory1" => "RawMaterialFactory1",
                "Factory2" => "RawMaterialFactory2",
                _ => throw new ArgumentException("Invalid factory name")
            };

            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();

                    // 1️⃣ Check current quantity
                    string checkQuery = $"SELECT Quantity FROM RawMaterials WHERE MaterialName = @name";
                    int currentQty = 0;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@name", materialName);
                        var result = checkCmd.ExecuteScalar();
                        if (result != null)
                            currentQty = Convert.ToInt32(result);
                        else
                        {
                            MessageBox.Show($"{materialName} does not exist in {factory}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }

                    // 2️⃣ Subtract or remove
                    if (currentQty <= quantity)
                    {
                        // Delete row if removing all or more than existing
                        string deleteQuery = $"DELETE FROM RawMaterials WHERE MaterialName = @name";
                        using (SqlCommand delCmd = new SqlCommand(deleteQuery, con))
                        {
                            delCmd.Parameters.AddWithValue("@name", materialName);
                            delCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Update remaining quantity
                        string updateQuery = $"UPDATE RawMaterials SET Quantity = Quantity - @qty WHERE MaterialName = @name";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@qty", quantity);
                            updateCmd.Parameters.AddWithValue("@name", materialName);
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating material: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }


}
