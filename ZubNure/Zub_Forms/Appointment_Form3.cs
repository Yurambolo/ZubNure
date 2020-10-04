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
            dens.Appointments.Add(new Appointment(user, doctor, monthCalendar1.SelectionStart.ToString() + " " + comboBox1.Text));
            day.Booked_time.Add(comboBox1.Text);
            dens.Save();
            this.Close();
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
    }
}
