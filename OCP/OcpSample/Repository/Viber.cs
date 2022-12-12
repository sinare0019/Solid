using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpSample
{
   public class Viber: ISendMessage
    {
        public void Message(string message)
        {
            Console.Write("send Viber Message:"+ message);
        }
    }
}
