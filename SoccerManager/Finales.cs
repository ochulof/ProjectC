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
    public partial class Finales : Form
    {
        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsPouleA;
        DataSet dsPouleB;

        public Finales()
        {
            InitializeComponent();
            maakWedstrijden();
            setLabels();
        }

        private void maakWedstrijden()
        {
            dsPouleA = wsSoccer.SelectKlassement("A");
            dsPouleB = wsSoccer.SelectKlassement("B");

            wsSoccer.UpdateFinaleWedstrijden("1001", dsPouleA.Tables[0].Rows[0][0].ToString(), 
                                                        dsPouleB.Tables[0].Rows[0][0].ToString(), "16:00");

            wsSoccer.UpdateFinaleWedstrijden("1003", dsPouleA.Tables[0].Rows[1][0].ToString(),
                                                        dsPouleB.Tables[0].Rows[1][0].ToString(), "15:15");

            wsSoccer.UpdateFinaleWedstrijden("1005", dsPouleA.Tables[0].Rows[2][0].ToString(),
                                                        dsPouleB.Tables[0].Rows[2][0].ToString(), "14:30");

            wsSoccer.UpdateFinaleWedstrijden("1007", dsPouleA.Tables[0].Rows[3][0].ToString(),
                                                        dsPouleB.Tables[0].Rows[3][0].ToString(), "13:45");

            wsSoccer.UpdateFinaleWedstrijden("1009", dsPouleA.Tables[0].Rows[4][0].ToString(),
                                                        dsPouleB.Tables[0].Rows[4][0].ToString(), "13:00");

            wsSoccer.UpdateFinaleWedstrijden("1011", dsPouleA.Tables[0].Rows[5][0].ToString(),
                                                        dsPouleB.Tables[0].Rows[5][0].ToString(), "13:00");

        }

        private void setLabels()
        {
            //11e plaats
            label8.Text = dsPouleA.Tables[0].Rows[5][0].ToString();
            label14.Text = dsPouleB.Tables[0].Rows[5][0].ToString();

            //9e plaats
            label9.Text = dsPouleA.Tables[0].Rows[4][0].ToString();
            label15.Text = dsPouleB.Tables[0].Rows[4][0].ToString();

            //7e plaats
            label10.Text = dsPouleA.Tables[0].Rows[3][0].ToString();
            label16.Text = dsPouleB.Tables[0].Rows[3][0].ToString();

            //5e plaats
            label11.Text = dsPouleA.Tables[0].Rows[2][0].ToString();
            label17.Text = dsPouleB.Tables[0].Rows[2][0].ToString();

            //3e plaats
            label12.Text = dsPouleA.Tables[0].Rows[1][0].ToString();
            label18.Text = dsPouleB.Tables[0].Rows[1][0].ToString();

            //1e plaats
            label13.Text = dsPouleA.Tables[0].Rows[0][0].ToString();
            label19.Text = dsPouleB.Tables[0].Rows[0][0].ToString();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            maakKeuze("1011",dsPouleA.Tables[0].Rows[5][0].ToString(),
                                dsPouleB.Tables[0].Rows[5][0].ToString());
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            maakKeuze("1009", dsPouleA.Tables[0].Rows[4][0].ToString(),
                                dsPouleB.Tables[0].Rows[4][0].ToString());
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            maakKeuze("1007", dsPouleA.Tables[0].Rows[3][0].ToString(),
                                dsPouleB.Tables[0].Rows[3][0].ToString());
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            maakKeuze("1005", dsPouleA.Tables[0].Rows[2][0].ToString(),
                                dsPouleB.Tables[0].Rows[2][0].ToString());
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            maakKeuze("1003", dsPouleA.Tables[0].Rows[1][0].ToString(),
                                dsPouleB.Tables[0].Rows[1][0].ToString());
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            maakKeuze("1001", dsPouleA.Tables[0].Rows[0][0].ToString(),
                                dsPouleB.Tables[0].Rows[0][0].ToString());
        }

        private void maakKeuze(string wedstrijd, string thuis, string uit)
        {
            Keuze k = new Keuze();
            k.ShowDialog();
            String optie = k.getTerug();
            if (optie.Equals("bewerk")) //als je de wedstrijd gegevens wil bewerken
            {
                GespeeldeWedstrijd gespeeld = new GespeeldeWedstrijd(thuis, uit,wedstrijd);
                gespeeld.ShowDialog();
            }
            else if (optie.Equals("wedstrijdblad")) //als je het wedstrijdblad van deze wedstrijd wil afdrukken
            {
                //printBlad();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
