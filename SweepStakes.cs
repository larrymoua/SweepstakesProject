using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        Random random;
        Dictionary<int, Contestant> contestantList;
        Contestant newContestant;
        public SweepStakes(string name)
        {
            Contestant newContestant = new Contestant();
            contestantList = new Dictionary<int, Contestant>();
            random = new Random();
        }
        public void RegisterContestant(Contestant contestant)
        {
            int randomNumber = random.Next(0, 100);
            contestantList.Add(randomNumber,contestant);
        }
        public string PickWinner()
        {
            
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
