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
    public partial class Form3 : Form
    {
        public List<string> arabalar = new List<string>();

        public Form3(List<string> must)
        {
            InitializeComponent();
            this.arabalar = must;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arabalar.Add(comboBox1.Text);
            arabalar.Add(textBox2.Text);
            arabalar.Add(textBox3.Text);
            
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Select();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
