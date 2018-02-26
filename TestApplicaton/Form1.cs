using System;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HttpResponseMessage res = new HttpResponseMessage();
            res.ReasonPhrase = "Enter your name";
            Form2 frm2 = new Form2(res);
            frm2.Show(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if(tbUsername.Text=="amal" && tbPassword.Text=="amal")
            {
                Form2 obj = new Form2();
                obj.Show();
            }
        }
    }
}
