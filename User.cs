using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem
{
    public class User
    {
        private string realname;
        private string username;
        private string password;


        public Boolean checkPassword(string pass)
        {
            if (password.ToLower().Equals(password.ToLower()))
            {
                return true;
            }
            return false;
        }

        public string Realname { get { return realname; } set { realname = value; } }
        public string Username { get { return username; } set { username = value; } }

        public string Password { get { return password; } set { password = value; } }
    }
}
