using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class TeamModel
    {
        public List<PersonModel> TeamMemebers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
