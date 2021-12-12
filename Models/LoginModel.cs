using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Models
{
  public class LoginModel
    {
        public string login { get; set; }
        public string password { get; set; }

        public string BirthDate { get; set; }
        public bool? Success { get; set; }

    }
}
