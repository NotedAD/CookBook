using CookBook.Classes;
using CookBook.UserControls;
using Microsoft.VisualBasic;
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
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            GenerateDynamicDevicesControl();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введите название прибора, который вы хотите изменить!");

            AddEdtDevices addEdtDevices = new AddEdtDevices();
            addEdtDevices.isChange = true;
            addEdtDevices.nameSearch = title;
            if (addEdtDevices.nameSearch.Length == 0)
            {
                MessageBox.Show("Вы не ввели прибор", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addEdtDevices.Show();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название прибора, который вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить прибор?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM devices WHERE name = '{title}'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                GenerateDynamicDevicesControl();
                MessageBox.Show("Прибор успешно удалена!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить прибор!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddEdtDevices addEdtDevices = new AddEdtDevices();
            addEdtDevices.Show();
        }

        private void GenerateDynamicDevicesControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLLDeviceUC objbll = new ClassBLLDeviceUC();

            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DevicesUserControl[] listItems = new DevicesUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new DevicesUserControl();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Name = row["name"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            GenerateDynamicDevicesControl();
        }

        private void Devices_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
