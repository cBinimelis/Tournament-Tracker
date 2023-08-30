using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Hacer que el metodo CreatePrize realmente guarde informacion a la base de datos
        /// <summary>
        /// Guarda un nuevo premio a la base de datos.
        /// Se crea una conexión utilizando los paquetes Nuget System.Data.SqlClient y Dapper
        /// Se agrega cada variable según la información requerida por su procedimiento almacenado
        /// </summary>
        /// <param name="model">Se le entrega la clase modelo del premio</param>
        /// <returns>La  información del premio, incluído el identificador único del nuevo elemento creado</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PriceAmount);
                p.Add("@PrizePercentage", model.PricePercentage);
                p.Add("@id",0,dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}
