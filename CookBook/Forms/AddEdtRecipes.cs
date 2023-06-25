using CookBook.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CookBook.Forms
{
    public partial class AddEdtRecipes : Form
    {
        public OpenFileDialog opendlg = new OpenFileDialog();
        public bool isChange;
        public string nameSearch;
        public AddEdtRecipes()
        {
            InitializeComponent();
        }

        private void AddEdtRecipes_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            if (isChange)
            {

                string queryInfo = $"SELECT name, description, dish_type, image FROM recipes WHERE name LIKE @nameSearc";
                MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                mySqlCommand.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    edt_name.Text = reader[0].ToString();
                    edt_description.Text = reader[1].ToString();
                    cbb_typeRecip.Text = reader[2].ToString();

                    string ifImage = "";
                    if (ifImage != reader[3].ToString())
                    {
                        System.Drawing.Image img = (Bitmap)((new ImageConverter()).ConvertFrom(reader[3]));
                        pb_image.Image = img;
                        pb_image.Invalidate();
                    }
                }
                reader.Close();

            }
            db.closeConnection();

        }
        private void upload_img_Click(object sender, EventArgs e)
        {
            opendlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*\r\n";
            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(opendlg.FileName);
                    pb_image.Image = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("Загружаемая вами иконка силшком большая", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                try
                {
                    DB db = new DB();
                    MySqlCommand command = new MySqlCommand($"UPDATE recipes SET name = @name, description = @description, dish_type = @dish_type, image = @image WHERE name LIKE @nameSearc", db.getConnection());

                    db.openConnection();
                    command.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                    command.Parameters.AddWithValue("@name", edt_name.Text);
                    command.Parameters.AddWithValue("@description", edt_description.Text);
                    command.Parameters.AddWithValue("@dish_type", cbb_typeRecip.Text);
                    if (opendlg.FileName == "")
                    {
                        opendlg.FileName = $"defaultImage.png";
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@image", File.ReadAllBytes($"{opendlg.FileName}"));
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Рецепт успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Не удалось изменить рецепт!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                    ClassBLLRecipesUC objbll = new ClassBLLRecipesUC();
                    if (objbll.SaveItem(pb_image.Image, edt_name.Text, edt_description.Text, cbb_typeRecip.Text))
                    {
                        if (pb_image.Image == null || edt_name.Text == null || edt_description.Text == null || cbb_typeRecip.Text == null)
                        {
                            MessageBox.Show("Вы не добавили какой-то из элементов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Рецепт загружен!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось загрузить рецепт!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
    }
    
}

