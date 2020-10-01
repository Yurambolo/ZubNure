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
    public partial class Doctrors_Form : Form
    {
        Dentistry dens;
        int index;
        public Doctrors_Form()
        {
            InitializeComponent();
            dens = new Dentistry();
            dens.FillTD(4);
            index = 0;
            var curr = dens.Doctors[index];
            pictureBox2.Image = curr.Image;
            label3.Text = curr.Name_Acives;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Doctrors_Form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curr = dens.Doctors.Where(doctor => doctor.Name_Acives == comboBox1.Text).ToList()[0];
            reset(curr);
            index = dens.Doctors.FindIndex(doctor => doctor.Name_Acives == comboBox1.Text);
        }
        private void reset(Doctor curr)
        {
            pictureBox2.Image = curr.Image;
            label3.Text = curr.Name_Acives;
            index = dens.Doctors.FindIndex(doctor => doctor.Name_Acives == curr.Name_Acives);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                var curr = dens.Doctors[--index];
                pictureBox2.Image = curr.Image;
                label3.Text = curr.Name_Acives;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index + 1 < dens.Doctors.Count)
            {
                var curr = dens.Doctors[++index];
                pictureBox2.Image = curr.Image;
                label3.Text = curr.Name_Acives;
            }
        }
    }
}
