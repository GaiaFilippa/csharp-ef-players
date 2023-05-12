using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Example
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Score { get; set; }
        public int PlayedGames { get; set; }
        public int Victories { get; set; }


        public Player(string name, string surname, int score, int playedGames, int victories)
        {

            Name = name;
            Surname = surname;
            Score = score;
            PlayedGames = playedGames;
            Victories = victories;

        }



        public override string ToString()
        {
            string rapprStringa = "- Name: " + Name + ", Surname: " + Surname + ", Matches: " + PlayedGames + ", Victories: " + Victories + ", Score: " + Score;
            return rapprStringa;
        }

    }
}
