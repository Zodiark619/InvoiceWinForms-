using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WinFormsApp1.Data;

namespace WinFormsApp1
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
            Thread.CurrentThread.CurrentCulture =
       CultureInfo.GetCultureInfo("en-US");

            Thread.CurrentThread.CurrentUICulture =
                CultureInfo.GetCultureInfo("en-US");
            ApplicationConfiguration.Initialize();
            using (var db = new ApplicationDbContext())
            {
                db.Database.Migrate();   // ? creates tables if missing
            }
            Application.Run(new Form1());
        }
            //using (var db = new ApplicationDbContext())
            //{
            //    db.Database.EnsureCreated();
            //}
    }
}