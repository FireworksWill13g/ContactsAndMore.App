using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAndMore
{
    public class Loan
    {

        // If you want private properties, you will need to change the names 
        //and pull them from the public properties

        // private decimal _loanAmount;
        // private decimal _APR;
        // private int _loanDuration;

        // make consturctor of object

        public Loan(decimal loanAmount, decimal APR, int loanDuration)
        {
            _loanAmount = loanAmount;
            _APR = APR;
            _loanDuration = loanDuration;

        }
        // properties 
        public decimal _loanAmount { get; set; }
        public decimal _APR { get; set; }
        public int _loanDuration { get; set; }

        //Need to figure out how to return the payment to the form1 class
        public string LoanPayment()
        {
            decimal rate = _APR / 12;
            decimal T = rate * _loanAmount;
            decimal B = (1 - ((decimal)Math.Pow((1 + (Convert.ToDouble(rate))), -(_loanDuration))));
            decimal payment = T / B;
            return string.Format("{0:C}", payment);

        }

        //Sample Calculation need to change variables

        //    double r = R / 12;

        //    double T = (r) * (Double.Parse(PV));
        //    double B = (1 - ((double)Math.Pow((1 + (r)), -(n))));
        //    double payment = T / B;
        //}

    }
}
