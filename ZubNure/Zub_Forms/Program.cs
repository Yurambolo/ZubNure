using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< Updated upstream
            Application.Run(new Home_form());
=======
            Application.Run(new HomeForm());
>>>>>>> Stashed changes
=======
            Application.Run(new Form1());
>>>>>>> parent of 3985d8e... Header_1
        }
    }
}
