using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoccerManager
{
    public partial class Nieuw_Team : Form
    {
        private String strAppName = "formulier Nieuw_Team";
        private Logging.Logging LoggingService;
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        public Nieuw_Team()
        {
            LoggingService = new Logging.Logging(1);
            InitializeComponent();
            
        }

        private void Nieuw_Team_Load(object sender, EventArgs e)
        {

        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            if (!(tb_team.Text.Equals("") || tb_verantwoordelijke.Text.Equals("") || tb_straat.Text.Equals("") || tb_postcode.Text.Equals("") || tb_plaats.Text.Equals("") || tb_tel.Text.Equals("") || tb_mail.Text.Equals("")))
            {

                wsSoccer.AddTeamGegevens(tb_team.Text, tb_verantwoordelijke.Text, tb_straat.Text, tb_postcode.Text, tb_plaats.Text, tb_tel.Text, tb_mail.Text);
                wsSoccer.AddTeamNaam(tb_team.Text);
                LoggingService.WriteLine(strAppName, "Een nieuw team is toegevoegd ");
            }
            else
            {
                LoggingService.WriteLine(strAppName, "Niet alle velden zijn correct ingevuld");
                MessageBox.Show("Vul alle velden in!", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
    }
}
