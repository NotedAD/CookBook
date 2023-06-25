using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Classes
{
    internal class ClassDBIngreUC
    {
        public bool AddItemsToTable(Image img, string name, string unitCalc)
        {
            DB db = new DB();

            db.openConnection();

            string query = "INSERT INTO ingredients(name, image, unit_calculation) VALUES (@name, @image, @unitCalc)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                {
                    if (name == null || unitCalc == null || img == null)
                    {
                        MessageBox.Show("Вы не ввели данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@name", name.Trim());
                        cmd.Parameters.AddWithValue("@unitCalc", unitCalc.Trim());
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

        public DataTable ReadItemsTable()
        {
            DB db = new DB();

            db.openConnection();

            string query = "SELECT * FROM ingredients";
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
