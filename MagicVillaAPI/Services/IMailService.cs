namespace MagicVillaAPI.Services
{
    public interface IMailService
    {
        void Send(string message, string subject);
    }
}
