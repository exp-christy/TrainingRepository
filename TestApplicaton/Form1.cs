﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace TestApplicaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked !!!!!.....");
            Form3 frm3 = new Form3();
            frm3.Show(this);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}
