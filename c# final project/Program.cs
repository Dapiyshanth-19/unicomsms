using c__final_project.Data;
using System;
using System.Windows.Forms;

namespace c__final_project
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
           
            Migration.Createtables();

            
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
