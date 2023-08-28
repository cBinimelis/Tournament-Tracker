using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<IDataConnection> Connections { get; private set; }

        // Metodo utilizado para revisar que tipo de base de datos se utilizará o si se utilizarán todos los disponibles
        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                // TODO - Crer una conexión para SQL
            }

            if (textfiles)
            {
                // TODO - Crear una conexión para texto
            }
        }
    }
}
