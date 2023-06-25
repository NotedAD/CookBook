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
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            GenerateDynamicIngredientsControl();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddEdtIngredients addEdtIngredients = new AddEdtIngredients();
            addEdtIngredients.Show();
        }

        private void GenerateDynamicIngredientsControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLLIngreUC objbll = new ClassBLLIngreUC();

            DataTable dt = objbll.GetItems();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    IngredientsUserControl[] listItems = new IngredientsUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new IngredientsUserControl();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Name = row["name"].ToString();
                            listItems[i].UnitCalc = row["unit_calculation"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            GenerateDynamicIngredientsControl();
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введите название ингридиента, который вы хотите изменить!");

            AddEdtIngredients addEdtIngredients = new AddEdtIngredients();
            addEdtIngredients.isChange = true;
            addEdtIngredients.nameSearch = title;
            if (addEdtIngredients.nameSearch.Length == 0)
            {
                MessageBox.Show("Вы не ввели ингридиент", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addEdtIngredients.Show();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название ингридиента, который вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить ингридиент?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM ingredients WHERE name = '{title}'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());
                cmd.ExecuteNonQuery();

                GenerateDynamicIngredientsControl();
                MessageBox.Show("Ингридиент успешно удалена!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить ингридиент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }

        private void Ingredients_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
