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
    public partial class CreateTournamenForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avaliableTeams = GlobalConfig.Connection.GetTeams_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamenForm()
        {
            InitializeComponent();
            WireUpLists();

        }

        private void WireUpLists()
        {
            dd_selectTeam.DataSource = null;
            dd_selectTeam.DataSource = avaliableTeams;
            dd_selectTeam.DisplayMember = "TeamName";

            lb_tournamentTeam.DataSource = null;
            lb_tournamentTeam.DataSource = selectedTeams;
            lb_tournamentTeam.DisplayMember = "TeamName";

            lb_prize.DataSource = null;
            lb_prize.DataSource = selectedPrizes;
            lb_prize.DisplayMember = "PlaceName";
        }

        private void btn_addTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)dd_selectTeam.SelectedItem;

            if (t == null)
            {
                MessageBox.Show("Debes seleccionar a alguien para quitar de la lista");
            }
            else
            {
                avaliableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void btn_addPrize_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }
    }
}
