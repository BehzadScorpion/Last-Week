using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lesson_13_Part_2
{
    static class Program
    {
        public static ParentForm parentform;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            parentform = new ParentForm();
            Application.Run(parentform);
        }
    }
}
