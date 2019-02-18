using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        string name;
        Contestant winnerNumber;
        Random random;
        Dictionary<int, Contestant> contestants;
        int contestantRegistrationNumbers;

        public SweepStakes(string name)
        {
            contestantRegistrationNumbers = 1;
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
            random = new Random();
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestantRegistrationNumbers;
            contestants.Add(contestantRegistrationNumbers, contestant);
            
            ++contestantRegistrationNumbers;
        }
        public string PickWinner()
        {
            int size = contestants.Count;
            winnerNumber = contestants[random.Next(0, size)];
            return winnerNumber.FirstName;
        }
        public void PrintContestantInfo()
        {
            string nameOfWinner = PickWinner();
            Console.WriteLine($"{name} Sweeps Stakes Winner : ");
            winnerNumber.DisplayContestantInfo();
        }
    }
}
