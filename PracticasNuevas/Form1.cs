﻿using PracticasNuevas.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasNuevas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsCalcular objCalc = new clsCalcular();
            MessageBox.Show($"{objCalc.CalculateSum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))}");
        }
    }
}
