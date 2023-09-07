using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPersons_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { Nombre = "Tim", Apellido = "Corey" });
            availableTeamMembers.Add(new PersonModel { Nombre = "Sue", Apellido = "Storm" });

            selectedTeamMembers.Add(new PersonModel { Nombre = "Jane", Apellido = "Smith" });
            selectedTeamMembers.Add((new PersonModel { Nombre = "Bill", Apellido = "Jones" }));
        }

        private void WireUpLists()
        {
            dd_selectMember.DataSource = availableTeamMembers;
            dd_selectMember.DisplayMember = "nombreCompleto";

            lb_tournamentPlayers.DataSource = selectedTeamMembers;
            lb_tournamentPlayers.DisplayMember = "nombreCompleto";
        }
        private void btn_createMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel();

                person.Nombre = tb_nombreJugador.Text.Trim();
                person.Apellido = tb_apellidoJugador.Text.Trim();
                person.Correo = tb_correoJugador.Text.Trim();
                person.NumTelefono = tb_telefonoJugador.Text.Trim();

                GlobalConfig.Connection.CreatePerson(person);

                tb_nombreJugador.Text = "";
                tb_apellidoJugador.Text = "";
                tb_correoJugador.Text = "";
                tb_telefonoJugador.Text = "";

                MessageBox.Show("¡Creado exitosamente!");
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (tb_nombreJugador.Text.Length == 0)
            {
                output = false;
            }

            if (tb_apellidoJugador.Text.Length == 0)
            {
                output = false;
            }

            if (tb_correoJugador.Text.Length == 0)
            {
                output = false;
            }

            if (tb_telefonoJugador.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }
    }
}
