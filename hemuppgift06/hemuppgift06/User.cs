using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace hemuppgift06
{
    public class User
    {
        //property
        UserRole Role { get; set; }

        //constructor
        public User(UserRole role)
        {
            Role = role;
        }
        
        //method
        public void PrintRoleMessage()
        {
            switch (Role)
            {
                case (UserRole.admin):
                    Console.WriteLine($"welcome, {UserRole.admin}! you have full access");
                    break;
                case (UserRole.moderator):
                    Console.WriteLine($"welcome, {UserRole.moderator}! you can manage content");
                    break;
                case (UserRole.user):
                    Console.WriteLine($"welcome, {UserRole.user}! you can manage content");
                    break;
                case(UserRole.guest):
                    Console.WriteLine($"welcome, {UserRole.guest}! you have limited access");
                    break;
            }
        }
    }
}
