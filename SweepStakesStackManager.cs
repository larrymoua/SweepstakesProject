using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepstakesManager
    {
        Stack<SweepStakes> stack = new Stack<SweepStakes>();
        SweepStakes pop;
        public void InsertSweepStakes(SweepStakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public SweepStakes GetSweepStakes()
        {
            pop = stack.Pop();
            return pop;
        }
    }
}

