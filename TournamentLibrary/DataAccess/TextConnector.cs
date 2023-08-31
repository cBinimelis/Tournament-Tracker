 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        // TODO - Hacer que el metodo CreatePrize (Texto) realmente guarde informacion a la base de datos
        /// <summary>
        /// Guarda un nuevo precio a la base de datos
        /// </summary>
        /// <param name="model">La información del precio</param>
        /// <returns>La  información del producto, incluído el identificador único</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {

        }
    }
}
