namespace MagicVillaAPI.Logging
{
    public class Logging : ILogging
    {
        private static int _id;
        public Logging()
        {
            _id++;
        }
        public void Log(string message, string type="")
        {
            Console.Write($"{_id} :");
            if (type == "error")
            {
                Console.WriteLine("ERORR - " + message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
