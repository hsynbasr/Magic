namespace MagicVillaAPI.Services
{
    public class LocalMailService : IMailService
    {
        private static int id;
        private string _mailTo = string.Empty;
        private string _mailFrom = string.Empty;

        //private string _mailTo = "testerTo@test.com";
        //private string _mailFrom = "testerFrom@test.com";
        public LocalMailService(IConfiguration configuration)
        {
            _mailFrom = configuration["mailSettings:mailFromAddress"]!;
            _mailTo = configuration["mailSettings:mailToAddress"]!;
            id++;
        }
        public void Send(string message, string subject)
        {
            Console.WriteLine($"FROM {_mailFrom} TO {_mailTo} \nSUBJECT : {subject} \nMESSAGE : {message}");
        }
    }
}
