using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant firstContestant = new Contestant();
            Contestant secondContestant = new Contestant();
            Contestant thirdContestant = new Contestant();
            SweepStakes sweepStakes = new SweepStakes("Bucks");
            sweepStakes.RegisterContestant(firstContestant);
            sweepStakes.RegisterContestant(secondContestant);
            sweepStakes.RegisterContestant(thirdContestant);
            sweepStakes.PrintContestantInfo();
            
        }
    }
}
