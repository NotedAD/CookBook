using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UserControls
{
    public partial class RecipesUserControl : UserControl
    {
        public RecipesUserControl()
        {
            InitializeComponent();
        }
        private Image _icon;
        private string _name;
        private string _dishType;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            { _icon = value; pb_icon.Image = value; }
        }

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set
            { _name = value; lbl_name.Text = value; }
        }

        [Category("Custom Props")]
        public string DishType
        {
            get { return _dishType; }
            set
            { _dishType = value; lbl_dishType.Text = value; }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_dishType_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pb_icon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void RecipesUserControl_Load(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
