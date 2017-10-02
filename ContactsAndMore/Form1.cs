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

            // Need to make a method that grabe the changed column and set that up for change only instead of updating all 


            var personID = (int)peopleDataGridView.Rows[e.RowIndex].Cells[0].Value;  //casting this as a int
            UpDateChanges(e.ColumnIndex, e.RowIndex, personID);
        }

        void UpDateChanges(int ColumnIndex, int RowIndex, int personID)
        {
            using (var ctx = new ContactsSqliteDB())
            {
                var person = ctx.Persons.SingleOrDefault(p => p.PersonID == personID);

                if (person != null && ColumnIndex == 1)
                {
                    var firstName = (string)peopleDataGridView.Rows[RowIndex].Cells[ColumnIndex].Value;
                    person.FirstName = firstName;
                }
                else if (person != null && ColumnIndex == 2)
                {
                    var lastName = (string)peopleDataGridView.Rows[RowIndex].Cells[ColumnIndex].Value;
                    person.LastName = lastName;
                }
                else if (person != null && ColumnIndex == 3)
                {
                    var personEmail = (string)peopleDataGridView.Rows[RowIndex].Cells[ColumnIndex].Value;
                    person.PersonEmail = personEmail;
                }

                ctx.SaveChanges();
                var result = ctx.SaveChanges();

                MessageBox.Show(string.Format("{0}'s info has updated to {1}", person.FirstName, result));
                GetLists();

            }

        }
        /*Loan Calculation Panel/View */

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoanAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _InitLoanAmt = LoanAmount.Text;

        }

        private void APR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string result = CalculateMoPayments();
            monthlyAmount.Text = result + " /Month";
            monthlyAmount.Refresh();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // Some Code to Clear Text from boxes
            LoanAmount.ResetText();
            APR.ResetText();
            LTerm.ResetText();
            monthlyAmount.ResetText();

        }

        public string CalculateMoPayments()
        {
            var lAmount = Convert.ToDecimal(LoanAmount.Text);
            var aPR = Convert.ToDecimal(APR.Text);
            var lTerm = Convert.ToInt16(LTerm.Text);
            //Loan userLoan = new Loan(lAmount, aPR, lTerm);

            // find a way to use object to make calculation 

            Loan usrLoan = new Loan(lAmount, aPR, lTerm);
            return usrLoan.LoanPayment();
        }

        private void calculateMonthlyPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalMoPayPanel.Visible = true;
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalMoPayPanel.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}

