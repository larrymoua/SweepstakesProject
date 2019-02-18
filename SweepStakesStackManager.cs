using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepstakesManager
    {
        public void InsertSweepStakes(SweepStakes sweepstakes)
        {
            Stack<SweepStakes> stack = new Stack<SweepStakes>();
            stack.Push(sweepstakes);
        }
        public SweepStakes GetSweepStakes()
        {
            return new SweepStakes("hi");
        }
    }
}

