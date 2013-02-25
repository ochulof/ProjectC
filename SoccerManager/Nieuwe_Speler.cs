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
    public partial class Nieuwe_Speler : Form
    {
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
         public System.Windows.Forms.TextBox[] tekstvakken;
         DataSet dsSoccer;
         private String strAppName = "formulier Nieuwe_Speler";
         private Logging.Logging LoggingService;
        public Nieuwe_Speler()
        {
            LoggingService = new Logging.Logging(1);
            InitializeComponent();
            voegTeamsToe();
             tekstvakken = new System.Windows.Forms.TextBox[20];
            tekstvakken[0] = textBox1;
            tekstvakken[1] = textBox2;
            tekstvakken[2] = textBox3;
            tekstvakken[3] = textBox4;
            tekstvakken[4] = textBox5;
            tekstvakken[5] = textBox6;
            tekstvakken[6] = textBox7;
            tekstvakken[7] = textBox8;
            tekstvakken[8] = textBox9;
            tekstvakken[9] = textBox10;
            tekstvakken[10] = textBox11;
            tekstvakken[11] = textBox12;
            tekstvakken[12] = textBox13; 
            tekstvakken[13] = textBox14;
            tekstvakken[14] = textBox15;
            tekstvakken[15] = textBox16;
            tekstvakken[16] = textBox17;
            tekstvakken[17] = textBox18;
            tekstvakken[18] = textBox19;
            tekstvakken[19] = textBox20;
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tekstvakken.Length - 2; i = i + 2)
            {
                if (!tekstvakken[i].Text.Equals("") && !tekstvakken[i + 1].Text.Equals(""))
                {
                    wsSoccer.AddSpelerGegevens(tekstvakken[i].Text, tekstvakken[i + 1].Text, "test");
                    LoggingService.WriteLine(strAppName, "Er is een nieuwe naam toegevoegd");
                }
                
            }

            

        }

        private void voegTeamsToe()
        {
            List<string> teams = new List<string>();

            dsSoccer = wsSoccer.SelectTeamNaam();
            this.cmb_team.DataSource = dsSoccer.Tables[0];
            this.cmb_team.DisplayMember = "naam";
            this.cmb_team.ValueMember = "naam";


        }

       
        
    }
}
