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
    public partial class IngredientsUserControl : UserControl
    {
        public IngredientsUserControl()
        {
            InitializeComponent();
        }
        private Image _icon;
        private string _name;
        private string _unitCalc;

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
        public string UnitCalc
        {
            get { return _unitCalc; }
            set
            { _unitCalc = value; lbl_unit_calc.Text = value; }
        }

    }
}
