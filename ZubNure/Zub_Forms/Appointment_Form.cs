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
    public partial class Appointment_Form : Form
    {
        Dentistry dens;
        public Appointment_Form(Dentistry dens)
        {
            InitializeComponent();
            this.dens = dens;
        }

        private void Appointment_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User newuser = new User(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text,textBox4.Text,textBox5.Text);
            var f = new Appointment_Form2(dens, newuser);
            this.Hide();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                this.Close();
        }
    }
}
