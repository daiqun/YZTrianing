using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Client.Student;
using Client.Teacher;
using Logic.StudentServiceReference;
using Logic.LoginServiceReference;

namespace Client
{
    /// <summary>
    /// Program init
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (Login.userRoleId == 3)
                {
                    Application.Run(new StudentPlat());
                }
                else if (Login.userRoleId == 4)
                {
                    Application.Run(new TeacherManage());
                }
            }
            else
            {
                Application.Exit();
            }

            Application.Run();
        }
    }
}