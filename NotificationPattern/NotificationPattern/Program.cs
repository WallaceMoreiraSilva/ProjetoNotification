using System;
using System.Text.Json;

namespace NotificationPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var verify = new Verifier().Execute();
            
            Console.WriteLine(JsonSerializer.Serialize(verify));
        }
    }
}
