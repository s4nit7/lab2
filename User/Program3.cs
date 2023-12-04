using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.User
{
    class Program3
    {
        static void Main(string[] args)
        {
            User user = new User("elliot_alderson", "Elliot", "Alderson", "28");
            user.DisplayUserInfo();
            Console.Write(user);
        }
    }
}
