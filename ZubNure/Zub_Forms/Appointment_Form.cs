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
        Doctor doctor;
        public Appointment_Form(Dentistry dens)
        {
            InitializeComponent();
            this.dens = dens;
        }

        public Appointment_Form(Dentistry dens, Doctor doctor)
        {
            InitializeComponent();
            this.dens = dens;
            this.doctor = doctor;
        }

        private void Appointment_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                string message = "Fill all the fields";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            if (textBox4.Text.Length < 10 || textBox4.Text.Length > 13)
            {
                string message = "Phone number format should be '+380*********'";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            User newuser = new User(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text,textBox4.Text,textBox5.Text);
            if (doctor == null)
                Main_Form.MenuNav(this, new Appointment_Form2(dens,newuser));
            else
                Main_Form.MenuNav(this, new Appointment_Form3(dens, newuser, doctor));
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Main_Form.MenuNav(this, new Doctrors_Form(dens));
        }

        private void Main_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Main_Form.MenuNav(this, new Main_Form(dens));
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Main_Form.MenuNav(this, new Serv_form(dens));
        }

        private void About_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Main_Form.MenuNav(this, new Comment_Form(dens));
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы хотите покинуть форму записи? Все изменения будут потеряны",
                "Предупреждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (textBox4.Text.Length == 1 && ch == 8)
                e.Handled = true;
            if (!Char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
