using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Piece_emp : Worker
    {
        private decimal Paymentforpiece;
        private int amount;

        public Piece_emp(string FSname, string LSname, decimal PaymentforP, int amount) : base(FSname, LSname)
        {
            Paymentforpiece = PaymentforP;
            Amount = amount;
        }
        public decimal PaymentforP
        {
            get
            {
                return Paymentforpiece;
            }
            set
            {
                if(value > 0)
                    Paymentforpiece = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value > 0)
                    amount = value;

            }
        }
        public override decimal Income()
        {
            return Amount * PaymentforP;
        }
        public override string ToString()
        {
            return "Piece_emp:" + base.ToString();
        }
    }
}
 