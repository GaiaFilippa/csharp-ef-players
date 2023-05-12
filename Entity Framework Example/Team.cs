using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Entity_Framework_Example
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Coach { get; set; }
        public string Colors { get; set; }

        public Team(string teamName, string city, string coach, string colors)
        {
            this.TeamName = teamName;
            this.City = city;
            this.Coach = coach;
            this.Colors = colors;
        }

        public override string ToString()
        {
            string rapprStringa = "Team Name: " + TeamName + "\n City: " + City + "\n Coach: " + Coach + "\n Colors: " + Colors + "\n";
            return rapprStringa;
        }


    }
}
