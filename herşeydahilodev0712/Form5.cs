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
    public partial class Form5 : Form
    {
        public List<string> arabalar = new List<string>();
        public Form5(List<string> must)
        {
            InitializeComponent();
            this.arabalar = must;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            switch (comboBox1.Text)
            {
                case "BMW":
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        y = y + 2;
                        if (mrk == "BMW")
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }
                    }
                    break;

                case "Mercedes":
                    
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        y = y + 2;

                        if (mrk == "Mercedes")
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }                     
                    }
                    break;

                case "Audi":                    
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        y = y + 2;
                        if (mrk == "Audi")
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }                        
                    }
                    break;

                case "Volkswagen":
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        y = y + 2;
                        if (mrk == "Volkswagen")
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }
                    }
                    break;
            }
            
        }
    }
}
