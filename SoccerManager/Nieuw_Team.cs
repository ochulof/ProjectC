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
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsSoccer;
        public Nieuw_Team()
        {
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
            }
            else
                MessageBox.Show("Vul alle velden in!", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

  
    }
}
