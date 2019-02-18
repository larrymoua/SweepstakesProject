using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> queue = new Queue<SweepStakes>();
        SweepStakes dequeue;

        public void InsertSweepStakes(SweepStakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public SweepStakes GetSweepStakes()
        {
            dequeue = queue.Dequeue();

            return dequeue;
        }
    }
}
