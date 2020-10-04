using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zub_lib;

namespace Zub_Forms
{
    public partial class Main_Form : Form
    {
        Dentistry dens;
        public Main_Form()
        {
            InitializeComponent();
            dens = new Dentistry();
            dens.Load();
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
            var f = new Doctrors_Form(dens);
            this.Hide();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.Show();
        }

        private void Appoint_Click(object sender, EventArgs e)
        {
            var f = new Appointment_Form(dens);
            this.Hide();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.Show();
        }
    }
}
