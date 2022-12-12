using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSample
{
   public class ConfirmEmail
    {
        public bool Confirm(string email)
        {
            if (email.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
