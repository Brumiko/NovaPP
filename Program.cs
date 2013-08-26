using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NovaPP
{
    static class Program
    {
        public static string PathToLocalDB = @"\Program Files\NovaPP\NovaPP.sdf";
        public static string ConnString = "Data Source=" + PathToLocalDB;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new ReplikacijskaForma());
        }
    }
}