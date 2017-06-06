using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAndMore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_ContactsAndMore_ContactsSqliteDBDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this._ContactsAndMore_ContactsSqliteDBDataSet.People);

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToDb_Click(object sender, EventArgs e)
        {
            using (var ctx = new ContactsSqliteDB()) 
            {
                Person pers = new Person()
                {
                    // Need function or call to move to next row on click and enumerate person ID
                    // PersonID = 
                    FirstName = FirstName.Text, 
                    LastName = LastName.Text,
                    PersonEmail = e_mail.Text
                };

                ctx.Persons.Add(pers);
                ctx.SaveChanges();
            }
        }
    }
}
