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
            SweepStakes sweepStakes1 = new SweepStakes("Bucks");
            sweepStakes1.RegisterContestant(firstContestant);
            sweepStakes1.RegisterContestant(secondContestant);
            sweepStakes1.RegisterContestant(thirdContestant);

            SweepStakes sweepStakes2 = new SweepStakes("Packers");
            sweepStakes2.RegisterContestant(firstContestant);
            sweepStakes2.RegisterContestant(secondContestant);


        }
    }
}
