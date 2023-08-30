using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary
{
    /// <summary>
    /// Archivo de configuración global, se utiliza en esta ocasión debido a que el
    /// sistema requiere conectarse a distintos tipos de gestores de base de datos, así que
    /// los métodos deben ser accesibles para todos los componentes del sistema
    /// </summary>
    public static class GlobalConfig
    {

        // Se deja el método como privado para prevenir que sea modificado desde fuera del actual documento
        public static IDataConnection Connections { get; private set; }


        // Metodo utilizado para revisar que tipo de base de datos se utilizará o si se utilizarán todos los disponibles
        public static void InitializeConnections(string connectionType)
        {
            if (connectionType == "sql")
            {
                // TODO - Crer una conexión para SQL
                SqlConnector sql = new SqlConnector();
                Connections = sql;

            }
            else if (connectionType == "text")
            {
                // TODO - Crear una conexión para texto
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString (string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
