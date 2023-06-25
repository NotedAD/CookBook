using CookBook.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Forms
{
    public partial class AddEdtDevices : Form
    {
        public OpenFileDialog opendlg = new OpenFileDialog();
        public bool isChange;
        public string nameSearch;
        public AddEdtDevices()
        {
            InitializeComponent();
        }
        private void AddEdtDevices_Load(object sender, EventArgs e)
        {
            {
                if (isChange)
                {
                    DB db = new DB();

                    string queryInfo = $"SELECT name, image FROM devices WHERE name LIKE @nameSearc";
                    MySqlCommand mySqlCommand = new MySqlCommand(queryInfo, db.getConnection());

                    db.openConnection();
                    mySqlCommand.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        edt_name.Text = reader[0].ToString();

                        string ifImage = "";
                        if (ifImage != reader[1].ToString())
                        {
                            System.Drawing.Image img = (Bitmap)((new ImageConverter()).ConvertFrom(reader[1]));
                            pb_image.Image = img;
                            pb_image.Invalidate();
                        }
                    }
                    reader.Close();

                    db.closeConnection();
                }
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
                    MySqlCommand command = new MySqlCommand($"UPDATE devices SET name = @name, image = @image WHERE name LIKE @nameSearc", db.getConnection());

                    db.openConnection();
                    command.Parameters.AddWithValue("@nameSearc", "%" + nameSearch + "%");
                    command.Parameters.AddWithValue("@name", edt_name.Text);
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
                    MessageBox.Show("Прибор успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.closeConnection();
                }
                catch (Exception)
                {
                    MessageBox.Show($"Не удалось изменить прибор!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                ClassBLLDeviceUC objbll = new ClassBLLDeviceUC();
                if (objbll.SaveItem(pb_image.Image, edt_name.Text))
                {
                    if (pb_image.Image == null || edt_name.Text == null)
                    {
                        MessageBox.Show("Вы не добавили какой-то из элементов!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Прибор загружен!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить прибор!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
