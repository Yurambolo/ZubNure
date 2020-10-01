using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zub_Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            var f = new Doctrors_Form();
            this.Hide();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.Show();
        }
    }
}
