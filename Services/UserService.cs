using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWeb.Models;
namespace FirstWeb.Servises
{
    public class UserService
    {
       
     
        public bool CheckCredentials(string login, string password)
        {
            dbUsers userObj = new dbUsers();
            foreach (var oneUser in userObj.Users)
            {
               
                if (login == oneUser.login && password == oneUser.password)
                {
                    
                    return true;
                }
          
            }
            //return (login == "User" || password == "Password");
           
            return false;
        }
    }
}
