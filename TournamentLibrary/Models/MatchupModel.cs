﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Unique identifier for the 1 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of
        /// </summary>
        public int MarchupRound { get; set; }
    }
}
