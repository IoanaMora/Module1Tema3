using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_ClassLib
{
   public class Person
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserName { get; set; }
        public DateTime Birthday { get; set; }

        public Person( string userFirstName, string userLastName, string userName, DateTime birtday)
        {
            UserFirstName = userFirstName;
            UserLastName = userLastName;
            UserName = userName;
            Birthday = birtday;
        }

    }
}
