using CookBook.Classes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CookBook.Forms
{
    public partial class DetailedRecipe : Form
    {
        public string name;
        public string idRecipes;
        public string idDevices;
        public string idIngred;
        public DetailedRecipe()
        {
            InitializeComponent();
        }

        private void DetailedRecipe_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            DB db = new DB();

            string queryInfo = $"SELECT * FROM recipes WHERE name = '{name}'";
            MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());
            string queryInfoCbbDev = $"SELECT name FROM devices";
            MySqlCommand mySqlCommandCbbDev = new MySqlCommand(queryInfoCbbDev, db.getConnection());
            string queryInfoCbbIngr = $"SELECT name FROM ingredients";
            MySqlCommand mySqlCommandCbbIngr = new MySqlCommand(queryInfoCbbIngr, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                idRecipes = reader[0].ToString();
                lbl_name.Text = reader[1].ToString();
                lbl_description.Text = reader[2].ToString();
                lbl_dishType.Text = reader[3].ToString();
                string ifImage = "";
                if (ifImage != reader[4].ToString())
                {
                    System.Drawing.Image img = (Bitmap)((new ImageConverter()).ConvertFrom(reader[4]));
                    pb_img.Image = img;
                    pb_img.Invalidate();
                }
            }
            reader.Close();

            MySqlDataReader readerCbbDev = mySqlCommandCbbDev.ExecuteReader();
            while (readerCbbDev.Read())
            {
                cbb_devices.Items.Add(readerCbbDev[0].ToString());
            }
            readerCbbDev.Close();

            MySqlDataReader readerCbbIngr = mySqlCommandCbbIngr.ExecuteReader();
            while (readerCbbIngr.Read())
            {
                cbb_ingred.Items.Add(readerCbbIngr[0].ToString());

            }
            readerCbbIngr.Close();
            cbb_ingred.SelectedIndex = 0;
            string queryInfoSelIngr = $"SELECT unit_calculation FROM ingredients WHERE name = '{cbb_ingred.Text}'";
            MySqlCommand mySqlCommandSelIngr = new MySqlCommand(queryInfoSelIngr, db.getConnection());
            MySqlDataReader readerSelIngr = mySqlCommandSelIngr.ExecuteReader();
            while (readerSelIngr.Read())
            {
                lbl_unit.Text = readerSelIngr[0].ToString();
            }
            readerSelIngr.Close();


            string queryDevicesDGVDev = $"SELECT DISTINCT(devices.name) FROM devices " +
                $"INNER JOIN recipesDevices ON recipesDevices.id_devices = devices.id_devices " +
                $"INNER JOIN recipes ON recipes.id_recipes = recipesDevices.id_recipes WHERE recipes.name = '{lbl_name.Text}'";
            MySqlCommand mySqlCommandDGVDev = new MySqlCommand(queryDevicesDGVDev, db.getConnection());

            MySqlDataReader readerDGVDev = mySqlCommandDGVDev.ExecuteReader();
            List<string[]> dataDev = new List<string[]>();
            while (readerDGVDev.Read())
            {
                dataDev.Add(new string[1]);

                dataDev[dataDev.Count - 1][0] = readerDGVDev[0].ToString();
            }
            readerDGVDev.Close();
            foreach (string[] s in dataDev)
                dataGridView1.Rows.Add(s);

            string queryDevicesDGVIngr = $"SELECT DISTINCT(ingredients.name), recipesIngredients.quantity FROM recipes " +
                $"INNER JOIN recipesIngredients ON recipes.id_recipes = recipesIngredients.id_recipes " +
                $"INNER JOIN ingredients ON ingredients.id_ingredients = recipesIngredients.id_ingredients";
            using (MySqlCommand mySqlCommandDGVIngr = new MySqlCommand(queryDevicesDGVIngr, db.getConnection()))
            {
                MySqlDataReader readerDGVIngr = mySqlCommandDGVIngr.ExecuteReader();
                List<string[]> dataIngr = new List<string[]>();
                while (readerDGVIngr.Read())
                {
                    dataIngr.Add(new string[2]);

                    dataIngr[dataIngr.Count - 1][0] = readerDGVIngr[0].ToString();
                    dataIngr[dataIngr.Count - 1][1] = readerDGVIngr[1].ToString();
                }
                readerDGVIngr.Close();
                foreach (string[] s in dataIngr)
                    dataGridView2.Rows.Add(s);
            }
            db.closeConnection();
            
        }

        private void btn_addDev_Click(object sender, EventArgs e)
        {
            if (cbb_devices.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали прибор", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DB db = new DB();

                db.openConnection();

                string query = "INSERT INTO recipesDevices(id_recipes, id_devices) VALUES (@idRecipes, @idDevices)";
                string queryDevices = $"SELECT id_devices FROM devices WHERE name = '{cbb_devices.Text}'";
                try
                {
                    using (MySqlCommand mySqlCommandCbb = new MySqlCommand(queryDevices, db.getConnection()))
                    {
                        MySqlDataReader reader = mySqlCommandCbb.ExecuteReader();
                        while (reader.Read())
                        {
                            idDevices = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@idRecipes", idRecipes);
                        cmd.Parameters.AddWithValue("@idDevices", idDevices);
                        MessageBox.Show("Вы добавили прибор", "Success", MessageBoxButtons.OK);
                        cmd.ExecuteNonQuery();
                    }
                    dataGridView1.Rows.Clear();
                    string queryDevicesDGV = $"SELECT DISTINCT(devices.name) FROM devices " +
                        $"INNER JOIN recipesDevices ON recipesDevices.id_devices = devices.id_devices " +
                        $"INNER JOIN recipes ON recipes.id_recipes = recipesDevices.id_recipes WHERE recipes.name = '{lbl_name.Text}'";
                    using (MySqlCommand mySqlCommandDGV = new MySqlCommand(queryDevicesDGV, db.getConnection()))
                    {
                        MySqlDataReader readerDGV = mySqlCommandDGV.ExecuteReader();
                        List<string[]> data = new List<string[]>();
                        while (readerDGV.Read())
                        {
                            data.Add(new string[1]);

                            data[data.Count - 1][0] = readerDGV[0].ToString();
                        }
                        readerDGV.Close();
                        foreach (string[] s in data)
                            dataGridView1.Rows.Add(s);
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        private void btn_addIngrid_Click(object sender, EventArgs e)
        {
            if (cbb_ingred.SelectedIndex == -1 || edt_unitCalc.Text == "")
            {
                MessageBox.Show("Вы не выбрали ингридиент и не вписали кол-во", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DB db = new DB();

                db.openConnection();
                StringBuilder sb = new StringBuilder();

                string query = "INSERT INTO recipesIngredients(id_recipes, id_ingredients, quantity) VALUES (@idRecipes, @idIngredients, @quantity)";
                string queryIngredients = $"SELECT id_ingredients FROM ingredients WHERE name = '{cbb_ingred.Text}'";
                try
                {
                    using (MySqlCommand mySqlCommandCbb = new MySqlCommand(queryIngredients, db.getConnection()))
                    {
                        MySqlDataReader reader = mySqlCommandCbb.ExecuteReader();
                        while (reader.Read())
                        {
                            idDevices = reader[0].ToString();
                        }
                        reader.Close();
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, db.getConnection()))
                    {
                        cmd.Parameters.AddWithValue("@idRecipes", idRecipes);
                        cmd.Parameters.AddWithValue("@idIngredients", idDevices);
                        cmd.Parameters.AddWithValue("@quantity", edt_unitCalc.Text);
                        MessageBox.Show("Вы добавили ингридиент", "Success", MessageBoxButtons.OK);

                        cmd.ExecuteNonQuery();
                    }
                    dataGridView2.Rows.Clear();
                    string queryDevicesDGVIngr = $"SELECT DISTINCT(ingredients.name), recipesIngredients.quantity FROM recipes " +
                                   $"INNER JOIN recipesIngredients ON recipes.id_recipes = recipesIngredients.id_recipes " +
                                   $"INNER JOIN ingredients ON ingredients.id_ingredients = recipesIngredients.id_ingredients";
                    using (MySqlCommand mySqlCommandDGVIngr = new MySqlCommand(queryDevicesDGVIngr, db.getConnection()))
                    {
                        MySqlDataReader readerDGVIngr = mySqlCommandDGVIngr.ExecuteReader();
                        List<string[]> dataIngr = new List<string[]>();
                        while (readerDGVIngr.Read())
                        {
                            dataIngr.Add(new string[2]);

                            dataIngr[dataIngr.Count - 1][0] = readerDGVIngr[0].ToString();
                            dataIngr[dataIngr.Count - 1][1] = readerDGVIngr[1].ToString();
                        }
                        readerDGVIngr.Close();
                        foreach (string[] s in dataIngr)
                            dataGridView2.Rows.Add(s);
                    }
                }
                catch
                {
                    MessageBox.Show("Вы ввели кол-во продукта неверно", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delIngr_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название ингридиента, который вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить новость?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM recipesIngredients WHERE id_ingredients IN (SELECT id_ingredients FROM ingredients WHERE name = '{title}')";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ингрдиент успешно удален!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить ингрдиент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void btn_delDev_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название прибора, который вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить новость?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM recipesDevices WHERE id_devices IN (SELECT id_devices FROM devices WHERE name = '{title}')";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Прибор успешно удален!", "Success!");

            }
            else
            {
                MessageBox.Show("Не удалось удалить прибор!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void cbb_ingred_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            string queryInfoSelIngr = $"SELECT unit_calculation FROM ingredients WHERE name = '{cbb_ingred.Text}'";
            MySqlCommand mySqlCommandSelIngr = new MySqlCommand(queryInfoSelIngr, db.getConnection());
            db.openConnection();
            MySqlDataReader readerSelIngr = mySqlCommandSelIngr.ExecuteReader();
            while (readerSelIngr.Read())
            {
                lbl_unit.Text = readerSelIngr[0].ToString();
            }
            readerSelIngr.Close();
            db.closeConnection();
        }

        private void btn_Word_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (*.docx)|*.docx";
                sfd.FileName = "check.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridView2, sfd.FileName);
                }
            }
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount, ColumnCount + 1];

                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {

                    for (r = 0; r <= RowCount - 1; r++)
                    {
                            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";

                for (r = 0; r <= RowCount - 1; r++)
                {

                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {

                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }

                }
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;
                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                oDoc.SaveAs2(filename);
            }
        }
    }
}
