using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButtonAvion.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz Avionom";
            }
            if (radioButtonAutobus.Checked)
            {
                textBox1.Text = "Odabrali ste prijevoz Autobusom";
            }
            if (radioButtonVlastiti.Checked)
            {
                textBox1.Text = "Odabrali ste vlastiti prijevoz";
            }
        }
    }
}
