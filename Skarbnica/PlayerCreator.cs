using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarbnica
{
    public partial class PlayerCreator : Form
    {
        public List<string> Names { get; set; } = new List<string>();
        public PlayerCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Names.Add(textBox1.Text);
            Names.Add(textBox2.Text);
            Names.Add(textBox3.Text);
            Names.Add(textBox4.Text);

            Close();
        }
    }
}
