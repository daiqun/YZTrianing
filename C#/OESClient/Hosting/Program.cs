using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Services;

namespace Hosting
{
    /// <summary>
    /// Service program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Service is started
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(LoginService)))
            using (ServiceHost host2 = new ServiceHost(typeof(StudentService)))
            using (ServiceHost host3 = new ServiceHost(typeof(TeacherService)))
            {
                host.Open();
                Console.WriteLine("LoginService is started...");
                host2.Open();
                Console.WriteLine("StudentService is started...");
                host3.Open();
                Console.WriteLine("TeacherService is started...");

                Console.Read();
            }
        }
    }
}