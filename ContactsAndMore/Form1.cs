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

            GetLists();
        }

        private void GetLists()
        {
            // throw new NotImplementedException();
            using (var ctx = new ContactsSqliteDB())
            {
                peopleBindingSource.DataSource = ctx.Persons.Where(e => e.Active).OrderBy(e => e.FirstName).ToList();
            }
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void e_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToDb_Click(object sender, EventArgs e)
        {
            var firstName = FirstName.Text;
            var lastName = LastName.Text;
            var personalEmail = e_mail.Text;

            var person = new Person

            {
                Active = true,
                FirstName = firstName,
                LastName = lastName,
                PersonEmail = personalEmail

            };

            using (var ctx = new ContactsSqliteDB()) 
            {
                ctx.Persons.Add(person);
                ctx.SaveChanges();
                var result = ctx.SaveChanges();

                MessageBox.Show(string.Format("{0} Person Created", result));
                GetLists();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            GetLists();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var personID = (string)peopleDataGridView.Rows[e.RowIndex].Cells[0].Value;
                var firstName = (string)peopleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var lastName = (string)peopleDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                //Need to put code here to change items in the database, see Crud update on Udemy course
            }
        }
    }
}
