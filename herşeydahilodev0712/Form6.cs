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
    public partial class Form6 : Form
    {
        public List<string> arabalar = new List<string>();
        public Form6(List<string> must)
        {
            InitializeComponent();
            this.arabalar = must;
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            switch (comboBox1.Text)
            {
                case "1990-2000":
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        int a = int.Parse(yl);
                        y = y + 2;
                        if (1990<a && a<2000)
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }
                    }
                    break;

                case "2000-2010":

                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        int a = int.Parse(yl);
                        y = y + 2;
                        if (1999 < a && a < 2011)
                        {
                            string[] satır = { mrk, mdl, yl };
                            ListViewItem item = new ListViewItem(satır);
                            listView1.Items.Add(item);
                        }
                    }
                    break;

                case "2010-2023":
                    for (int i = 0; i < arabalar.Count() / 3; i++)
                    {
                        string mrk = arabalar[i + y];
                        string mdl = arabalar[i + y + 1];
                        string yl = arabalar[i + y + 2];
                        int a = int.Parse(yl);
                        y = y + 2;
                        if (2009 < a && a < 2024)
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
