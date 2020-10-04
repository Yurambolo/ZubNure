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
    public partial class Comment_Form : Form
    {
        int index;
        List<string> names;
        List<string> coment;
        public Comment_Form()
        {
            InitializeComponent();
            names = new List<string> { "Джон", "Мария", "Иван", "Заур", "Василий" };
            coment = new List<string> { "Клиника находится недалеко от момего дома.\n Резкая зубная боль появилась с самого утра,\n в мой выходной день:( Попал в эту клинику,\n они спасли меня в прямом и переносном смысле\n. Зубная боль - это ад.\n Спасибо за квалифицированную помощь.", "Не люблю стоматологов, как и все.\n Но гингивит заставил обратиться к стоматологу.\n Мне помогли за несколько сеансов\n решить мою проблему.", "Наблюдаюсь тут со своей дочкой.\n К Анюте быстро нашли подход врачи,\n хотя малышка у меня не очень любит\n врачей. Но как ни странно\n все приемы проходят не без нервов, конечно,\n но без истерик.", "Клиника находится\n недалеко от момего дома.\n Резкая зубная боль появилась с самого утра, в мой выходной день:( \nПопал в эту клинику, они спасли меня в прямом и переносном смысле.\n Зубная боль - это ад. Спасибо\n за квалифицированную помощь.", "Хорошая клиника"};
            index = 0;
            change();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void change()
        {
            int i = (index < 0) ? names.Count - Math.Abs(index % coment.Count) : index;
           
            label5.Text = names[i % coment.Count];
            label67.Text = names[(i + 1) % coment.Count];
            label77.Text = names[(i + 2) % coment.Count];
            label8.Text = coment[i % coment.Count];
            label9.Text = coment[(i + 1) % coment.Count];
            label10.Text = coment[(i + 2) % coment.Count];
        }
        private void Main_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Main_Form());
        }

        private void Doctors_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Doctrors_Form());
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Serv_form());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
