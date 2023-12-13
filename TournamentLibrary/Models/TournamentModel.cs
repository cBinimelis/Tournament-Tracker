using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// Represents a tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Unique identifier for the Tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name given to this tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The amount of money money each team needs to put up to enter
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// THe set of teams that have been entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }=new List<TeamModel>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
