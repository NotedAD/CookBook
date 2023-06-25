using CookBook.Classes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CookBook.Forms
{
    public partial class AddEdtIngredients : Form
    {
        public OpenFileDialog opendlg = new OpenFileDialog();
        public bool isChange;
        public string nameSearch;
        public AddEdtIngredients()
        {
            InitializeComponent();
        }

        private void AddEdtIngredients_Load(object sender, EventArgs e)
        {
            
                if (isChange)
                {
                    DB db = new DB();

                    string queryInfo = $"SELECT name, unit_calculation, image FROM ingredients WHERE name LIKE @nameSearc";
                    MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                    db.openConnection();
                    mySqlCommand.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        edt_name.Text = reader[0].ToString();
                        cbb_unitCalc.Text = reader[1].ToString();

                        string ifImage = "";
                        if (ifImage != reader[2].ToString())
                        {
                            System.Drawing.Image img = (Bitmap)((new ImageConverter()).ConvertFrom(reader[2]));
                            pb_image.Image = img;
                            pb_image.Invalidate();
                        }
                    }
                    reader.Close();

                    db.closeConnection();
                }
            
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
                        MySqlCommand command = new MySqlCommand($"UPDATE ingredients SET name = @name, unit_calculation = @unitCalc, image = @image WHERE name LIKE @nameSearc", db.getConnection());

                        db.openConnection();
                        command.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                        command.Parameters.AddWithValue("@name", edt_name.Text);
                        command.Parameters.AddWithValue("@unitCalc", cbb_unitCalc.Text);
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
                        MessageBox.Show("Ингридиент успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.closeConnection();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Не удалось изменить ингридиент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ClassBLLIngreUC objbll = new ClassBLLIngreUC();
                    if (objbll.SaveItem(pb_image.Image, edt_name.Text, cbb_unitCalc.Text))
                    {
                        if (pb_image.Image == null || edt_name.Text == null || cbb_unitCalc.Text == null)
                        {
                            MessageBox.Show("Вы не добавили какой-то из элементов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ингридиент загружен!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось загрузить ингридиент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            
        }


    }
}
