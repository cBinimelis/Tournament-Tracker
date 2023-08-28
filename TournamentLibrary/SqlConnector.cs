using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Hacer que el metodo CreatePrize realmente guarde informacion a la base de datos
        /// <summary>
        /// Guarda un nuevo precio a la base de datos
        /// </summary>
        /// <param name="model">La información del precio</param>
        /// <returns>La  información del producto, incluído el identificador único</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
