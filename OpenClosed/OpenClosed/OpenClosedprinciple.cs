using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class OpenClosedprinciple
    {
        public double GetInvoiceDiscount(double amount,InvoiceType invoiceType)
        {
            double finalAmount = 0;

            if(invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if(invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }

        public enum InvoiceType
        {
            FinalInvoice,
            ProposedInvoice
        }
        static void Main(string[] args)
        {
        }
    }
}
