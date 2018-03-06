using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplicaton
{
    public partial class Form2 : Form
    {
        private HttpResponseMessage _exception;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(HttpResponseMessage msg)
        {
            InitializeComponent();
            _exception = msg;
            lblExcep.Text = _exception.ReasonPhrase;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
