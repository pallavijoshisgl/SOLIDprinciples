using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedImplementation
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
        
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }

    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }

    public class RecurringInvoice :Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        { 
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice amount : 10000");

            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(FInvoiceAmount);


            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(PInvoiceAmount);

            Invoice RInvoice = new RecurringInvoice();
            double RinvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine(RinvoiceAmount);

            Console.ReadKey();

        }
    }
}
