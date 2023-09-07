using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique identifier for the Prize
        /// </summary>
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NumTelefono { get; set; }

        public string nombreCompleto
        {
            get
            {
                return $"{ Nombre } { Apellido }";
            }
        }
    }
}
