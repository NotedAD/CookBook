﻿using System;
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
    public partial class DevicesUserControl : UserControl
    {
        public DevicesUserControl()
        {
            InitializeComponent();
        }
        private Image _icon;
        private string _name;

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
    }
}
