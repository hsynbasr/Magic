namespace MagicVillaAPI.Services
{
    public class CloudMailService :IMailService
    {

        private string _mailTo = "testTo@tester.com";
        private string _mailFrom = "testFrom@tester.com";

        public void Send(string message, string subject)
        {
            Console.WriteLine($"{nameof(CloudMailService)} FROM {_mailFrom} TO {_mailTo} SUBJECT : {subject} MESSAGE : {message}");
        }
    }
}

