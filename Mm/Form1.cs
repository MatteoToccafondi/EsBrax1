﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> Lista = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
          for (int i = 0; i < 5; i++){
                 Lista.Add(Convert.ToInt32(textBox1.Text));
                 label5.Text = Lista.Min().ToString();
                 label4.Text = Lista.Max().ToString();
          }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
