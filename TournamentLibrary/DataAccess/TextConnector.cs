using TournamentLibrary.Models;
using TournamentLibrary.DataAccess.TextHelpers;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PeopleModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> person = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            person.Add(model);

            person.SaveToPersonFile(PeopleFile);

            return model;
        }

        /// <summary>
        /// Guarda un nuevo premio a la base de datos
        /// </summary>
        /// <param name="model">La información del premio</param>
        /// <returns>La  información del producto, incluído el identificador único</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Carga el archivo de texto y convierte el texto a List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //Encuentra el ID máximo
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public List<PersonModel> GetPersons_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
    }
}
