﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Omar Khallaf" && textBox2.Text == "200252")
            {
                label1.Text = "True";
                this.BackColor = Color.Green;
            } else{
                label1.Text = "False";
                this.BackColor = Color.Red;
            }


        }
    }
}
