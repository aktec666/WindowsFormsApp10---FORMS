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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 t = new Form2("текст про первую ошибку", Color.Red);
            t.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 t = new Form2("dfgfdhhgfh", Color.AliceBlue);
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 t = new Form2("dfgfdgfdgfdg \n\r + 13erfer + \n\r + sdgfdg", Color.Black);
            t.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
