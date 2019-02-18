using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        public void InsertSweepStakes(SweepStakes sweepstakes)
        {
            Queue<SweepStakes> queue = new Queue<SweepStakes>();
            queue.Enqueue(sweepstakes);
        }
        public SweepStakes GetSweepStakes()
        {
            return new SweepStakes("hi");
        }
    }
}
