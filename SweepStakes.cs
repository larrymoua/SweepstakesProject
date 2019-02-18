using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


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
            winnerNumber = contestants[random.Next(1, size)];
            return winnerNumber.FirstName;
        }
        public void NotifyContestants()
        {
            string youwin = $"Congradulations you won {name} sweeps stake!!!";
            string youlose = $"Thanks for participating , but you did not win {name} sweeps stakes";

            foreach(var contestant in contestants)
            {
                if (winnerNumber.RegistrationNumber == contestant.Value.RegistrationNumber)
                {
                    winnerNumber.GetUpdate(youwin);

                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress($"{name}", "sweepsstackproject@gmail.com"));
                    message.To.Add(new MailboxAddress($"{winnerNumber.FirstName} {winnerNumber.LastName}", "sweepsstackproject@gmail.com"));
                    message.Subject = "CONGRADULATIONS!";

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Hey,
                        Thanks for participating in our sweeps stake, please email us back to claim your prize.
                        -- CEO Larry"
                    };
                        using (var client = new SmtpClient())
                        {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("sweepsstackproject", "sweep12!!");
                        client.Send(message);
                        client.Disconnect(true);
                       
                        }
                }
                else
                {
                    contestant.Value.GetUpdate(youlose);


                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress($"{name}", "sweepsstackproject@gmail.com"));
                    message.To.Add(new MailboxAddress($"{winnerNumber.FirstName} {winnerNumber.LastName}", "sweepsstackproject@gmail.com"));
                    message.Subject = "THANK YOU!";

                    message.Body = new TextPart("plain")
                    {
                        Text = @"Hey,
                        Thanks for participating in our sweeps stake, but you did not win.
                        -- CEO Larry"
                    };
                    using (var client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        client.Connect("smtp.gmail.com", 587, false);
                        client.Authenticate("sweepsstackproject", "sweep12!!");
                        client.Send(message);
                        client.Disconnect(true);

                    }
                }
            }
        }
        public void PrintContestantInfo()
        {
            string nameOfWinner = PickWinner();
            NotifyContestants();
            Console.WriteLine($"{name} Sweeps Stakes Winner : ");
            winnerNumber.DisplayContestantInfo();
        }
    }
}
