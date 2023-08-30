using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
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

        public PrizeModel()
        {
            
        }
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            int placeNumberVal = 0;
            decimal priceAmountVal = 0;
            double prizePercentageVal = 0;

            PlaceName = placeName;
            int.TryParse(placeNumber, out placeNumberVal);
            PlaceNumber = placeNumberVal;

            decimal.TryParse(prizeAmount, out priceAmountVal);
            PriceAmount = priceAmountVal;

            double.TryParse(prizePercentage, out prizePercentageVal);
            PricePercentage = prizePercentageVal;
            
        }
    }
}
