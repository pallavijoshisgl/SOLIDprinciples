using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPImplemented
{

    public interface ILogger
    {
        void Info(string message);
        void Debug(string info);

        void Error(string message, Exception ex);
    }
    public class Logger:ILogger
    {
       
        void ILogger.Info(string message)
        {
            throw new NotImplementedException();
        }

        void ILogger.Debug(string info)
        {
            throw new NotImplementedException();
        }

        void ILogger.Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }
    }

    public class MailSender
    {
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }

        public string EmailSubject { get; set; }

        public string EmailBody { get; set; }

        public void SendEmail()
        {

        }
    }
    public class Invoice
    {

        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        private ILogger fileLogger;

        private MailSender mailSender;

        public Invoice()
        {
            fileLogger = new Logger();
            mailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method start");
                mailSender.EmailFrom = "emailfrom@xyz.com";
                mailSender.EmailTo = "emailto@xyz.com";
                mailSender.EmailSubject = "Single Responsibility Principle";
                mailSender.EmailBody = "A class should have only one reason to change";
                mailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error occurred while generating invoice ", ex);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                fileLogger.Info("Delete Invoice start at @" + DateTime.Now);
            }
            catch(Exception ex)
            {
                fileLogger.Error("Error occured while deleting invoice", ex);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
