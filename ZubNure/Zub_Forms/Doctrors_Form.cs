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
        public Doctrors_Form(Dentistry dens)
        {
            InitializeComponent();
            this.dens = dens;
            index = 0;
            var curr = dens.Doctors[index];
            reset(curr);
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curr = dens.Doctors.Where(doctor => doctor.Name_Acives == comboBox1.Text).ToList()[0];
            index = dens.Doctors.FindIndex(doctor => doctor.Name_Acives == comboBox1.Text);
            reset(curr);
            
        }
        private void reset(Doctor curr)
        {
            pictureBox2.Image = curr.Image;
            label3.Text = curr.Name_Acives;
            comboBox1.SelectedItem = comboBox1.Items[index];
            //изменение времени работы на форме
            for (int j = 0; j <= 7; j++)
            {
                Zub_lib.Day someday = curr.Availible_days[j];
                switch (someday.date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        label_mon.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Tuesday:
                        label_tues.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Wednesday:
                        label_wed.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Thursday:
                        label_thurs.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Friday:
                        label_fri.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Saturday:
                        label_sat.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;
                    case DayOfWeek.Sunday:
                        label_sun.Text = Convert.ToString(someday.time[0]) + " - " + Convert.ToString(someday.time[someday.time.Count - 1]);
                        break;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index - 1 >= 0)
            {
                var curr = dens.Doctors[--index];
                reset(curr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index + 1 < dens.Doctors.Count)
            {
                var curr = dens.Doctors[++index];
                reset(curr);
            }
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Main_Form(dens));
        }

        private void Appoint_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Appointment_Form(dens));
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Serv_form(dens));
        }

        private void About_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Comment_Form(dens));
        }
    }
}
