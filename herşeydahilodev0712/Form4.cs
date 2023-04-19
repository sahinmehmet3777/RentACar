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
    public partial class Form4 : Form
    {
        public List<string> arabalar = new List<string>();
        public Form4(List<string> must)
        {
            InitializeComponent();
            this.arabalar = must;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            int y = 0;
            for (int i = 0; i < arabalar.Count() / 3; i++)
            {
                string mrk = arabalar[i + y];
                string mdl = arabalar[i + y + 1];
                string yl = arabalar[i + y + 2];
                y = y + 2;
                string[] satır = { mrk, mdl, yl };
                ListViewItem item = new ListViewItem(satır);
                listView1.Items.Add(item);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "Marka")
            {
                Form5 form5 = new Form5(arabalar);
                form5.Show();
            }
            else if (comboBox1.Text == "Yıl")
            {
                Form6 form6 = new Form6(arabalar);
                form6.Show();
            }
        }
    }
}
