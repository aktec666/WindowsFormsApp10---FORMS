using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form2 : Form
    {
        public Form2(string text, Color t)
        {
            InitializeComponent();
            textBox1.Text = text;
            panel1.BackColor = t;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
