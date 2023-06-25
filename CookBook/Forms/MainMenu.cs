using CookBook.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void recipes_btn_Click(object sender, EventArgs e)
        {
            Recipes recipes = new Recipes();
            recipes.Show();
            this.Hide();
        }

        private void ingredients_btn_Click(object sender, EventArgs e)
        {
            Ingredients ingredients = new Ingredients();
            ingredients.Show();
            this.Hide();
        }

        private void devices_btn_Click(object sender, EventArgs e)
        {
            Devices devices = new Devices();
            devices.Show();
            this.Hide();
        }
    }
}
