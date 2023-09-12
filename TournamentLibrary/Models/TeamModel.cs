using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        public List<PersonModel> TeamMemebers { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
