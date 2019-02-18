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
            MarketingFirm marketingFirm;
            SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            SweepStakesStackManager sweepStakesStackManager = new SweepStakesStackManager();
      

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

            string input = UserInterfacecs.GetString("Do you want to use queue or stack manager?");
            input.ToLower();
            switch (input)
            {
                case "queue":
                    sweepstakesQueueManager.InsertSweepStakes(sweepStakes1);
                    sweepstakesQueueManager.InsertSweepStakes(sweepStakes2);
                    marketingFirm = new MarketingFirm(sweepstakesQueueManager);
                    break;
                case "stack":
                    sweepStakesStackManager.InsertSweepStakes(sweepStakes1);
                    sweepStakesStackManager.InsertSweepStakes(sweepStakes2);
                    marketingFirm = new MarketingFirm(sweepStakesStackManager);
                    break;
                default:
                    break;
            }

        }
    }
}
