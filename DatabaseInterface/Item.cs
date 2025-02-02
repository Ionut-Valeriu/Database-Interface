﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{
    public partial class Item : UserControl
    {
        public static string valueSelected;
        public static bool isSelected = false;
        public Item(Color c)
        {
            InitializeComponent();
            this.BackColor = c;
        }

        public void itemName(string name)
        {
            labelTabel.Text = name;
        }

        private void labelTabel_Click(object sender, EventArgs e)
        {
            isSelected = true;
            valueSelected = labelTabel.Text;
        }
    }
}
