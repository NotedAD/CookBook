using CookBook.Classes;
using CookBook.UserControls;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CookBook.Forms
{
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }
        private void Recipes_Load(object sender, EventArgs e)
        {
            GenerateDynamicRecipesControl();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void Recipes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddEdtRecipes addEdtRecipes = new AddEdtRecipes();
            addEdtRecipes.Show();
        }

        private void edt_btn_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введите название рецепта, который вы хотите изменить!");

            AddEdtRecipes addEdtRecipes = new AddEdtRecipes();
            addEdtRecipes.isChange = true;
            addEdtRecipes.nameSearch = title;
            if (addEdtRecipes.nameSearch.Length == 0)
            {
                MessageBox.Show("Вы не ввели ингридиент", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addEdtRecipes.Show();
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            string title = Interaction.InputBox("Введите название рецепта, который вы хотите удалить!");

            db.openConnection();

            if (MessageBox.Show("Вы действительно хотите удалить рецепт?", "Подтверждение удаления",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = $"DELETE FROM recipes WHERE name = '{title}'";
                MySqlCommand cmd = new MySqlCommand(query, db.getConnection());

                cmd.ExecuteNonQuery();

                GenerateDynamicRecipesControl();
                MessageBox.Show("Рецепт успешно удалена!", "Success!");
            }
            else
            {
                MessageBox.Show("Не удалось удалить рецепт!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
        }
        private void GenerateDynamicRecipesControl()
        {
            flowLayoutPanel1.Controls.Clear();
            ClassBLLRecipesUC objbll = new ClassBLLRecipesUC();

            DataTable dt = objbll.GetItems(edt_search.Text);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    RecipesUserControl[] listItems = new RecipesUserControl[dt.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listItems[i] = new RecipesUserControl();
                            MemoryStream ms = new MemoryStream((byte[])row["image"]);
                            listItems[i].Icon = new Bitmap(ms);
                            listItems[i].Name = row["name"].ToString();
                            listItems[i].DishType = row["dish_type"].ToString();

                            flowLayoutPanel1.Controls.Add(listItems[i]);

                            listItems[i].Click += new System.EventHandler(this.RecipesUserControl_Click);
                        }
                    }
                }
            }
        }

        void RecipesUserControl_Click(object sender, EventArgs e)
        {
            RecipesUserControl obj = (RecipesUserControl)sender;
            DetailedRecipe detailedRecipe = new DetailedRecipe();
            detailedRecipe.name = obj.Name;
            detailedRecipe.Show();
        }

        private void btn_upd_Click(object sender, EventArgs e)
        {
            GenerateDynamicRecipesControl();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GenerateDynamicRecipesControl();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.Width = 300;
            this.Height = 400;
            cbb_recipes.Items.Clear();
            DB db = new DB();
            string queryInfoCbb = $"SELECT name FROM recipes";
            MySqlCommand mySqlCommandCbb = new MySqlCommand(queryInfoCbb, db.getConnection());
            db.openConnection();

            MySqlDataReader readerCbb = mySqlCommandCbb.ExecuteReader();
            while (readerCbb.Read())
            {
                cbb_recipes.Items.Add(readerCbb[0].ToString());
            }
            readerCbb.Close();

            db.closeConnection();
            dataGridView1.Rows.Clear();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            this.Width = 816;
            this.Height = 514;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            dataGridView1.Rows.Clear();
            string queryDevicesDGVIngr = $"SELECT DISTINCT(ingredients.name), recipesIngredients.quantity FROM recipes " +
                                   $"INNER JOIN recipesIngredients ON recipes.id_recipes = recipesIngredients.id_recipes " +
                                   $"INNER JOIN ingredients ON ingredients.id_ingredients = recipesIngredients.id_ingredients WHERE recipes.name = '{cbb_recipes.Text}'";
            db.openConnection();
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
                    dataGridView1.Rows.Add(s);
            }
            db.closeConnection();

        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btn_raschet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double result1;
                Double.TryParse(dataGridView1[1, i].Value.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out result1);
                dataGridView1.Rows[i].Cells[2].Value = result1 * int.Parse(edt_count.Text);
            }
        }
    }
}
