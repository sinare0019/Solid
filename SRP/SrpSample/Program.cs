using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Register reg = new Register();
            Console.Write("Inpub Name: ");
            reg.Name = Console.ReadLine();
            Console.Write("Inpub Family: ");
            reg.Family = Console.ReadLine();
            Console.Write("Inpub Age: ");
            reg.Age = short.Parse(Console.ReadLine());
            Console.Write("Inpub Password: ");
            reg.Pasword = Console.ReadLine();
            Console.Write("Inpub Email: ");
            reg.Email = Console.ReadLine();
            ConfirmEmail conf = new ConfirmEmail();
            bool con = conf.Confirm(reg.Email);
            if(con == true)
            {
                Console.WriteLine("The email is correct");
            }
            else
            {
                Console.WriteLine("The email is incorrect");
            }
            Console.ReadKey();
        }
    }
}
