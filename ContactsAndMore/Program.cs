using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.Linq;


namespace ContactsAndMore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (var ctx = new ContactsSqliteDB()) // initialize the database
            {
                Person pers = new Person()
                {
                    FirstName = "TestFname"
                };

                ctx.Persons.Add(pers);
                ctx.SaveChanges();
            }
        }
    }
}
