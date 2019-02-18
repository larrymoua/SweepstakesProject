using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
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
            GetInfo();
        }
        public void GetInfo()//contestant enter there info
        {
            FirstName = UserInterfacecs.GetString("Enter your first name.");
            LastName = UserInterfacecs.GetString("Enter your last name.");
            EmailAddress = UserInterfacecs.GetString("Enter your email address.");
            Console.ReadLine();
            Console.Clear();
        }
        public void DisplayContestantInfo()
        {
            Console.WriteLine($"First Name : {FirstName}");
            Console.WriteLine($"Last Name : {LastName}");
            Console.WriteLine($"Registration Number : {RegistrationNumber}");
            Console.ReadLine();
        }
        public void GetUpdate(string winorlose)
        {
            Console.WriteLine(winorlose);
        }
    }
}
