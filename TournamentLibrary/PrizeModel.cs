using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    /// <summary>
    /// Represents the price of the tournament
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the Prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The place number of the winner team
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name given to the placement 
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The cash price for this placement
        /// </summary>
        public decimal PriceAmount { get; set; }

        /// <summary>
        /// The percentage of the tournament total money assigned to this placement
        /// </summary>
        public double PricePercentage { get; set; }
    }
}
