using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zub_lib;

namespace Zub_Forms
{
    public partial class Serv_form : Form
    {
        int index;
        List<string> service;
        List<string> servtext;
        public Serv_form()
        {
            InitializeComponent();
            service = new List<string> { "Лечение зубов", "Лечение дёсен", "Протезирование зубов", "Чистка зубов", "Отбеливание зубов", "Детская стоматология" };
            servtext = new List<string> { "Эффективное лечение заболиваний \n полости рта  с использованием\nсовременных технологий от 200 до 2000 грн", "Лечение парадонтоза,гингивита и \n др. болезней дёсен по доступной цене\n от 200 до 500 грн", "Качественное протезирование\n от 500 до 1500 грн", "Безболезненная процедура\nпоможет сохранить здоровье\n от 900 грн", "Современные методы \n отбеливания эмали\n от 400 до 800 грн", "Лечение ротовой полости \nссамого раннего возраста\n от 300 грн" };
            index = 0;
            change();


        }
        private void change()
        {
            int i = (index < 0) ? service.Count - Math.Abs(index % service.Count) : index;
            p1.Image = new Bitmap(Path.GetFullPath($"{service[i % service.Count]}.jpg"));
            p2.Image = new Bitmap(Path.GetFullPath($"{service[(i+1) % service.Count]}.jpg"));
            p3.Image = new Bitmap(Path.GetFullPath($"{service[(i + 2) % service.Count]}.jpg"));
            
            label3.Text = servtext[i % service.Count];
            label4.Text = servtext[(i + 1) % service.Count];
            label5.Text = servtext[(i + 2) % service.Count];
            label8.Text = service[i % service.Count];
            label9.Text = service[(i + 1) % service.Count];
            label10.Text = service[(i + 2) % service.Count];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            change();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            change();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Main_Form());
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Doctrors_Form());
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void About_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Comment_Form());
        }
    }
}
