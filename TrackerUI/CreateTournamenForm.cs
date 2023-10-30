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
    public partial class CreateTournamenForm : Form
    {
        List<TeamModel> avaliableTeams= GlobalConfig.Connection.GetTeams_All();

        public CreateTournamenForm()
        {
            InitializeComponent();
            InitializeLists();
        }

        private void InitializeLists()
        {
            dd_selectTeam.DataSource = avaliableTeams;
            dd_selectTeam.DisplayMember = "TeamName";
        }
    }
}
