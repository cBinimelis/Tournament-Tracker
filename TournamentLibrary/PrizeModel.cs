using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PriceAmount { get; set; }
        public double PricePercentage { get; set; }
    }
}
