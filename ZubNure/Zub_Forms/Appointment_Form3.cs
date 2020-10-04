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
    public partial class Appointment_Form3 : Form
    {
        Dentistry dens;
        User user;
        Doctor doctor;
        Zub_lib.Day day;
        public Appointment_Form3(Dentistry dens, User user, Doctor doctor)
        {
            InitializeComponent();
            this.dens = dens;
            this.user = user;
            this.doctor = doctor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                string message = "Выберите дату и время";
                string caption = "Ошибка ввода";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            dens.Appointments.Add(new Appointment(user, doctor, monthCalendar1.SelectionStart.ToString() + " " + comboBox1.Text));
            day.Booked_time.Add(comboBox1.Text);
            dens.Save();
            Main_Form.MenuNav(this, new Main_Form(dens));
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            day = doctor.FindDay(monthCalendar1.SelectionStart);
            if (day != null)
            {
                foreach(string time in day.time)
                {
                    if (day.Booked_time.IndexOf(time) == -1)
                        comboBox1.Items.Add(time);
                }
            }

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
    }
}
