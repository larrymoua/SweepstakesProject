using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        private string firstname;
        private string lastname;
        private string emailaddress;

      public string FirstName { get { return firstname; } set { firstname = value; } }
      public string LastName { get { return lastname; } set { lastname = value; } }
      public string EmailAddress { get { return emailaddress; } set { emailaddress = value; } }
      public int RegistrationNumber { get; set; }


  

        public Contestant()
        {
            

        }
    }
}
