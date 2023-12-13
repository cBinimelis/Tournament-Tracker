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

        private void btn_deletePlayer_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)lb_tournamentTeam.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                avaliableTeams.Add(t);

                WireUpLists();
            }
        }

        private void btn_deletePrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)lb_prize.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void btn_createTournament_Click(object sender, EventArgs e)
        {
            //validar valor ingresado en la tarifa
            decimal fee = 0;
            bool acceptableFee = decimal.TryParse(tb_entryFee.Text, out fee);
            if (!acceptableFee)
            {
                MessageBox.Show("Necesitas ingresar una tarifa valida.", "Tarifa Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Crear modelo de torneo
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tb_tournamentName.Text;
            tm.EntryFee = decimal.Parse(tb_entryFee.Text);

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;


        }
    }
}
