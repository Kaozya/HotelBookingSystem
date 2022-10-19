using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class AdminUser : User
    {
        private string private_key;
     
        public string Private_key { get { return private_key; } set { private_key = value; } }
    }
}
