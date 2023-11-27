using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            //code to add invoice
            //and then send mail
            MailMessage mailMessage = new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");
            this.sendInvoiceMail(mailMessage);
        }

        public void sendInvoiceMail(MailMessage mailMessage)
        {
            try
            {
                //Here we need to write the code for Email Setting and sending the invoice email
            }
            catch(Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }

        }

        public void deleteInvoice()
        {
            try
            {

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\ErrorlogText.txt", ex.ToString());
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
