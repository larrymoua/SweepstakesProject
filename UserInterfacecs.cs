using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterfacecs
    {
        public static string GetString(string prompt)
        {
            string result = "";

            Console.WriteLine(prompt);
            try
            {
                result = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("INVALID INPUT");
                GetString(prompt);
            }
            return result;
        }
    }
}
