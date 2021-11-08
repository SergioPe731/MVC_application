using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Models
{
    public class dbUsers
    {
        public List<User> Users = new List<User>
        {
            new User {login="Ivanov", password="ws124pG8", fullName="Иванов Михаил Петрович", BirthDate="22.07.1995"},
            new User {login="Petrov", password="I4vZ9w3l", fullName="Петров Иван Евгеньевич", BirthDate="18.11.1993"},
            new User {login="Симонов", password="BnmQ2kOpcz", fullName="Симонов Артём Игоревич", BirthDate="03.04.2000"},
            new User {login="Светлаков", password="GfetYu75", fullName="Светлаков Леонид Альбертович", BirthDate="14.02.1989"},
            new User {login="Паустовский", password="LUt59rAI4h", fullName="Паустовский Олег Владимирович", BirthDate="11.08.1998"}
        };

    }
}
