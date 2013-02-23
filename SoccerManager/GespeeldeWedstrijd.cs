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
    public partial class GespeeldeWedstrijd : Form
    {

        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsSpelersThuis;
        DataSet dsSpelersUit;
        private System.Windows.Forms.NumericUpDown[,] gegevensThuis;
        private System.Windows.Forms.NumericUpDown[,] gegevensUit;
        private System.Windows.Forms.Label[] labelThuis;
        private System.Windows.Forms.Label[] labelUit;
        int aantalThuis, aantalUit;

        public GespeeldeWedstrijd()
        {
            InitializeComponent();
            maakTabellen();
            setLabels();
        }

       
        public GespeeldeWedstrijd(string thuis, string uit, string wedstrijd)
        {
            InitializeComponent();
            label1.Text = wedstrijd;
            lbl_thuis.Text = thuis;
            lbl_uit.Text = uit;
            maakTabellen();
            setLabels();
            setNumerics();
        }

        private void setNumerics()
        {
            for (int i = aantalThuis; i < 12; i++)
            {
                gegevensThuis[i, 0].Visible = false;
                gegevensThuis[i, 1].Visible = false;
                gegevensThuis[i, 2].Visible = false;
            }
            for (int i = aantalUit; i < 12; i++)
            {
                gegevensUit[i, 0].Visible = false;
                gegevensUit[i, 1].Visible = false;
                gegevensUit[i, 2].Visible = false;
            }
        }

        private void setLabels()
        {
            dsSpelersThuis = wsSoccer.SelectTeamGegevens(lbl_thuis.Text);
            aantalThuis = dsSpelersThuis.Tables[2].Rows.Count;
            dsSpelersUit = wsSoccer.SelectTeamGegevens(lbl_uit.Text);
            aantalUit = dsSpelersUit.Tables[2].Rows.Count;

            for (int i = 0; i < aantalThuis; i++)
                labelThuis[i].Text = dsSpelersThuis.Tables[2].Rows[i][1] + " " + dsSpelersThuis.Tables[2].Rows[i][0];
            for (int i = 0; i < aantalUit; i++)
                labelUit[i].Text = dsSpelersUit.Tables[2].Rows[i][1] + " " + dsSpelersUit.Tables[2].Rows[i][0];
        }

        private void maakTabellen()
        {
            labelThuis = new System.Windows.Forms.Label[12];
            labelUit = new System.Windows.Forms.Label[12];

            //labels thuisploeg
            labelThuis[0] = label11;
            labelThuis[1] = label12;
            labelThuis[2] = label13;
            labelThuis[3] = label14;
            labelThuis[4] = label15;
            labelThuis[5] = label16;
            labelThuis[6] = label17;
            labelThuis[7] = label18;
            labelThuis[8] = label19;
            labelThuis[9] = label20;
            labelThuis[10] = label21;
            labelThuis[11] = label22;

            //labels uitploeg
            labelUit[0] = label23;
            labelUit[1] = label24;
            labelUit[2] = label25;
            labelUit[3] = label26;
            labelUit[4] = label27;
            labelUit[5] = label28;
            labelUit[6] = label29;
            labelUit[7] = label30;
            labelUit[8] = label31;
            labelUit[9] = label32;
            labelUit[10] = label33;
            labelUit[11] = label34;

            //gegevens thuisploeg
            gegevensThuis = new System.Windows.Forms.NumericUpDown[12, 3];
            gegevensThuis[0, 0] = numericUpDown1; gegevensThuis[0, 1] = numericUpDown13; gegevensThuis[0, 2] = numericUpDown25;
            gegevensThuis[1, 0] = numericUpDown2; gegevensThuis[1, 1] = numericUpDown14; gegevensThuis[1, 2] = numericUpDown26;
            gegevensThuis[2, 0] = numericUpDown3; gegevensThuis[2, 1] = numericUpDown15; gegevensThuis[2, 2] = numericUpDown27;
            gegevensThuis[3, 0] = numericUpDown4; gegevensThuis[3, 1] = numericUpDown16; gegevensThuis[3, 2] = numericUpDown28;
            gegevensThuis[4, 0] = numericUpDown5; gegevensThuis[4, 1] = numericUpDown17; gegevensThuis[4, 2] = numericUpDown29;
            gegevensThuis[5, 0] = numericUpDown6; gegevensThuis[5, 1] = numericUpDown18; gegevensThuis[5, 2] = numericUpDown30;
            gegevensThuis[6, 0] = numericUpDown7; gegevensThuis[6, 1] = numericUpDown19; gegevensThuis[6, 2] = numericUpDown31;
            gegevensThuis[7, 0] = numericUpDown8; gegevensThuis[7, 1] = numericUpDown20; gegevensThuis[7, 2] = numericUpDown32;
            gegevensThuis[8, 0] = numericUpDown9; gegevensThuis[8, 1] = numericUpDown21; gegevensThuis[8, 2] = numericUpDown33;
            gegevensThuis[9, 0] = numericUpDown10; gegevensThuis[9, 1] = numericUpDown22; gegevensThuis[9, 2] = numericUpDown34;
            gegevensThuis[10, 0] = numericUpDown11; gegevensThuis[10, 1] = numericUpDown23; gegevensThuis[10, 2] = numericUpDown35;
            gegevensThuis[11, 0] = numericUpDown12; gegevensThuis[11, 1] = numericUpDown24; gegevensThuis[11, 2] = numericUpDown36;

            //gegevens uitploeg
            gegevensUit = new System.Windows.Forms.NumericUpDown[12, 3];
            gegevensUit[0, 0] = numericUpDown37; gegevensUit[0, 1] = numericUpDown49; gegevensUit[0, 2] = numericUpDown61;
            gegevensUit[1, 0] = numericUpDown38; gegevensUit[1, 1] = numericUpDown50; gegevensUit[1, 2] = numericUpDown62;
            gegevensUit[2, 0] = numericUpDown39; gegevensUit[2, 1] = numericUpDown51; gegevensUit[2, 2] = numericUpDown63;
            gegevensUit[3, 0] = numericUpDown40; gegevensUit[3, 1] = numericUpDown52; gegevensUit[3, 2] = numericUpDown64;
            gegevensUit[4, 0] = numericUpDown41; gegevensUit[4, 1] = numericUpDown53; gegevensUit[4, 2] = numericUpDown65;
            gegevensUit[5, 0] = numericUpDown42; gegevensUit[5, 1] = numericUpDown54; gegevensUit[5, 2] = numericUpDown66;
            gegevensUit[6, 0] = numericUpDown43; gegevensUit[6, 1] = numericUpDown55; gegevensUit[6, 2] = numericUpDown67;
            gegevensUit[7, 0] = numericUpDown44; gegevensUit[7, 1] = numericUpDown56; gegevensUit[7, 2] = numericUpDown68;
            gegevensUit[8, 0] = numericUpDown45; gegevensUit[8, 1] = numericUpDown57; gegevensUit[8, 2] = numericUpDown69;
            gegevensUit[9, 0] = numericUpDown46; gegevensUit[9, 1] = numericUpDown58; gegevensUit[9, 2] = numericUpDown70;
            gegevensUit[10, 0] = numericUpDown47; gegevensUit[10, 1] = numericUpDown59; gegevensUit[10, 2] = numericUpDown71;
            gegevensUit[11, 0] = numericUpDown48; gegevensUit[11, 1] = numericUpDown60; gegevensUit[11, 2] = numericUpDown72;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int scoreThuis = Convert.ToInt32(score_thuis.Value);
            int scoreUit = Convert.ToInt32(score_uit.Value);
            String thuisPloeg = lbl_thuis.Text;
            String uitPloeg = lbl_uit.Text;

            //UPDATE WEDSTRIJDEN
            wsSoccer.UpdateWedstrijden(label1.Text, scoreThuis, scoreUit, tb_opmerking.Text);
            
            //UPDATE TEAMS
            if (score_thuis.Value > score_uit.Value)
            {
                //thuisploeg wint, uitploeg verliest
                wsSoccer.UpdateTeamGewonnen(thuisPloeg, scoreThuis, scoreUit);
                wsSoccer.UpdateTeamVerloren(uitPloeg, scoreUit, scoreThuis);

            }
            else if (score_thuis.Value < score_uit.Value)
            {
                //uitploeg wint, thuisploeg verliest
                wsSoccer.UpdateTeamGewonnen(uitPloeg, scoreUit, scoreThuis);
                wsSoccer.UpdateTeamVerloren(thuisPloeg, scoreThuis, scoreUit);
            }
            else
            {
                //gelijkspel
                wsSoccer.UpdateTeamGelijk(uitPloeg, scoreUit, scoreThuis);
                wsSoccer.UpdateTeamGelijk(thuisPloeg, scoreThuis, scoreUit);
            }

            String naam="",voornaam="";
            int goals=0, geel=0, rood=0;

            //UPDATE SPELERS thuisploeg
            for (int i = 0; i < aantalThuis; i++)
            {
                naam = dsSpelersThuis.Tables[2].Rows[i][0].ToString();
                voornaam = dsSpelersThuis.Tables[2].Rows[i][1].ToString();
                goals = Convert.ToInt32(gegevensThuis[i, 0].Value);
                geel = Convert.ToInt32(gegevensThuis[i, 1].Value);
                rood = Convert.ToInt32(gegevensThuis[i, 2].Value);
                wsSoccer.UpdateSpelers(naam, voornaam, goals, geel, rood);
            }

            //UPDATE SPELERS uitploeg
            for (int i = 0; i < aantalUit; i++)
            {
                naam = dsSpelersUit.Tables[2].Rows[i][0].ToString();
                voornaam = dsSpelersUit.Tables[2].Rows[i][1].ToString();
                goals = Convert.ToInt32(gegevensUit[i, 0].Value);
                geel = Convert.ToInt32(gegevensUit[i, 1].Value);
                rood = Convert.ToInt32(gegevensUit[i, 2].Value);
                wsSoccer.UpdateSpelers(naam, voornaam, goals, geel, rood);
            }
             
        }

    }
}
