using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        public MarketingFirm()
        {

        }
        public void ChooseStackOrQueue()
        {
            string input = UserInterfacecs.GetString("Do you want to use queue or stack manager?");
            input.ToLower();
            switch (input)
            {
                case "queue":
                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    break;
                case "stack":
                    SweepStakesStackManager
                    break;
                default:
                    break;
            }
        }
    }
}
