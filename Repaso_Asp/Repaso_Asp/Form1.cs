﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Asp
{
    public partial class Form1 : Form
    {
        int total = 1;
        int resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero.Text = "1";
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            resultado = resultado + total;
            txtNumero.Text = resultado.ToString();
        }
    }
}
