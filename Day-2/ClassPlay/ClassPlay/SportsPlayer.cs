using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlay
{
    internal class SportsPlayer
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string SportsName { get; set; }
        public int YearsOfPlaying { get; set; }

        public int Age { get; set; }
        public SportsPlayer() { }
        public SportsPlayer(int id,string name,string sportname, int playingyear, int age)
        {
            PlayerId = id;
            PlayerName = name;
            SportsName = sportname;
            YearsOfPlaying = playingyear;
            Age = age;
        }

      public void GetPlayerDetais()
        {
            Console.WriteLine("playerID " + PlayerId);
            Console.WriteLine("PlayerName " + PlayerName);
            Console.WriteLine("SportsName " + SportsName);
            Console.WriteLine("YearsOfPlaying " + YearsOfPlaying);
            Console.WriteLine("Age " + Age);
           

        }
       
    }
}
