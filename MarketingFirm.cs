using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        List<ISweepstakesManager> sweepstakesManagers;
        ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            sweepstakesManagers = new List<ISweepstakesManager>();
            this.sweepstakesManager = sweepstakesManager;
        }
        public void AddSweepsStakes()
        {
            sweepstakesManagers.Add(sweepstakesManager);
        }
        public void PrepareManager()
        {
            foreach(ISweepstakesManager manager in sweepstakesManagers)
            {
                manager.GetSweepStakes();
            }
        }
    }
}
