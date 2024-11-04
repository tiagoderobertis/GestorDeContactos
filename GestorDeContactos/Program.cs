using GestorDeContactos.Data;
using Microsoft.EntityFrameworkCore;

namespace GestorDeContactos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var context = new ApplicationDBContext())
            {
                context.Database.Migrate();
                Application.Run(new Form1(context));
            }
        }
    }
}