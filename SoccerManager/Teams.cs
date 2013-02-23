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
    public partial class Teams : Form
    {
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsTeams;
        DataSet dsTeamGegevens;
        public Teams()
        {
            InitializeComponent();
            voegTeamsToe();
        }

        private void voegTeamsToe()
        {
            dsTeams = wsSoccer.SelectTeamNaam();
            this.comboBox1.DataSource = dsTeams.Tables[0];
            this.comboBox1.DisplayMember = "naam";
            this.comboBox1.ValueMember = "naam";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dsTeamGegevens = wsSoccer.SelectTeamGegevens("Racing Genk");
            lbl_verantwoordelijke.Text = dsTeamGegevens.Tables[0].Rows[0]["verantwoordelijke"].ToString();
            lbl_adres.Text = dsTeamGegevens.Tables[0].Rows[0]["straat_nr"].ToString();
            lbl_email.Text = dsTeamGegevens.Tables[0].Rows[0]["email"].ToString();
            lbl_plaats.Text = dsTeamGegevens.Tables[0].Rows[0]["plaats"].ToString();
            lbl_postcode.Text = dsTeamGegevens.Tables[0].Rows[0]["postcode"].ToString();
            lbl_telefoon.Text = dsTeamGegevens.Tables[0].Rows[0]["telefoon"].ToString();
            lbl_poule.Text = dsTeamGegevens.Tables[1].Rows[0]["poule"].ToString();

            DataTable dataTable = dsTeamGegevens.Tables.Add("spelers");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dsTeamGegevens.Tables[2];
            
                
        }
    }
}
