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
    public partial class Nieuwe_Wedstrijd : Form
    {

        private String strAppName = "formulier Nieuwe_Wedstrijd";
        private Logging.Logging LoggingService;
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsTeamsThuis, dsTeamsUit;


        public Nieuwe_Wedstrijd()
        {
            LoggingService = new Logging.Logging(1);
            InitializeComponent();
            
        }

        private void cb_poule_SelectedIndexChanged(object sender, EventArgs e)
        {
            voegTeamsToe();
        }
        private void voegTeamsToe()
        {
            dsTeamsThuis = wsSoccer.SelectTeamNaamPerPoule(cb_poule.Text);
            dsTeamsUit = wsSoccer.SelectTeamNaamPerPoule(cb_poule.Text);

            this.cb_thuis.DataSource = dsTeamsThuis.Tables[0];
            this.cb_uit.DataSource = dsTeamsUit.Tables[0];
            this.cb_thuis.DisplayMember = "naam";
            this.cb_thuis.ValueMember = "naam";
            this.cb_uit.DisplayMember = "naam";
            this.cb_uit.ValueMember = "naam";
            
        }
        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            string datum = dateTimePicker1.Value.Date.ToShortDateString();
            string[] wedstrijd = new string[8];
            
            wedstrijd[0] = cb_thuis.Text;
            wedstrijd[1] = cb_uit.Text;
            wedstrijd[2] = cb_terrien.Text;
            wedstrijd[3] = cb_poule.Text;
            wedstrijd[4] = datum;
            wedstrijd[5] = cb_uren.Text + ":" + cb_minuten.Text;
            wedstrijd[6] = tb_scheidsrechter.Text;
            wedstrijd[7] = tb_opmerking.Text;

            if (!(wedstrijd[4].Equals("") || wedstrijd[5].Equals(""))) //programma crasht als er geen tijdstip wordt ingegeven
            {
                wsSoccer.AddNieuweWedstrijd(wedstrijd[0], wedstrijd[1], wedstrijd[2], wedstrijd[3], wedstrijd[4], wedstrijd[5], wedstrijd[6], wedstrijd[7]);
                LoggingService.WriteLine(strAppName, "Een nieuwe wedstrijd is toegevoegd");
            }
        }
    }
}
