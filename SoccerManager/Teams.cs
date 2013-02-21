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

        }
    }
}
