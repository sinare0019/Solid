using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Telegram tel = new Telegram();
            string message;
            message = Console.ReadLine();
            tel.Message(message);
            Console.ReadKey();
        }
    }
}
