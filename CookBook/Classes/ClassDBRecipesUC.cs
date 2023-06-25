using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Classes
{
    internal class ClassDBRecipesUC
    {
        public bool AddItemsToTable(Image img, string name, string description, string dishType)
        {
            DB db = new DB();

            db.openConnection();

            string query = "INSERT INTO recipes(name, description, dish_type, image) VALUES (@name, @description, @dishType, @image)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    if (name == null || img == null || description == null || dishType == null)
                    {
                        MessageBox.Show("Вы не ввели данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@name", name.Trim());
                        cmd.Parameters.AddWithValue("@description", description.Trim());
                        cmd.Parameters.AddWithValue("@dishType", dishType.Trim());
                        MemoryStream ms = new MemoryStream();

                        if (img != null)
                        {
                            img.Save(ms, img.RawFormat);
                        }

                        cmd.Parameters.AddWithValue("@image", ms.ToArray());

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadItemsTable(string searchText)
        {
            DB db = new DB();

            db.openConnection();

            string query = $"SELECT * FROM recipes WHERE name LIKE '{searchText}%'";
            MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
            try
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
