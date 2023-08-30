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
using TournamentLibrary.DataAccess;
using TournamentLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void btn_createPrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    tb_positionNumber.Text,
                    tb_positionName.Text,
                    tb_prizeAmount.Text,
                    tb_prizePercentage.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

                tb_positionName.Text = "";
                tb_positionNumber.Text = "";
                tb_prizeAmount.Text = "0";
                tb_prizePercentage.Text = "0";

                MessageBox.Show("¡Premio creado exitosamente!");
            }
            else
            {
                MessageBox.Show("Información incompleta o incorrecta");
            }

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            double prizePercentage = 0;
            bool validPlaceNumber = int.TryParse(tb_positionNumber.Text, out placeNumber);
            bool validPrizeAmount = decimal.TryParse(tb_prizeAmount.Text, out prizeAmount);
            bool validPrizePercentage = double.TryParse(tb_prizePercentage.Text, out prizePercentage);

            if (!validPlaceNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (tb_positionName.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (!validPrizeAmount || !validPrizePercentage)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
