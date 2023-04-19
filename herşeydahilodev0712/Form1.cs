using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herşeydahilodev0712
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string skulladi = "admin";
        string ssifre = "12345";
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == skulladi && textBox2.Text == ssifre)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
            }
            else
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
        }
    }
}
