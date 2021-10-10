using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Servises
{
    public class UserService
    {
        public bool CheckCredentials(string login, string password)
        {
            return (login == "User" || password == "Password");
        }
    }
}
