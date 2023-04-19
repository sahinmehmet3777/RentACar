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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<string> arabalar1 = new List<string>();

        private void müşteriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(arabalar1);
            form3.MdiParent = this;
            form3.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(arabalar1);
            form4.MdiParent = this;
            form4.Show();
        }
    }
}
