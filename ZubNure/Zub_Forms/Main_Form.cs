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

        public static void MenuNav(Form first, Form second)
        {
            var f = second;
            first.Hide();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
                first.Show();
        }
        private void Doctors_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Doctrors_Form());
        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Serv_form());
        }

        private void About_Click(object sender, EventArgs e)
        {
            Main_Form.MenuNav(this, new Comment_Form());
        }
    }
}
