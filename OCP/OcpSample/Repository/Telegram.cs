using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpSample
{
   public class Telegram: ISendMessage
    {
        public void Message(string message)
        {
            Console.Write("new Telegram message: "+ message);
        }
    }
}
