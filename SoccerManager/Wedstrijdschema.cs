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
    public partial class Wedstrijdschema : Form
    {

        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet DsSoccer;

        public Wedstrijdschema()
        {
            InitializeComponent();

            vulGrid("");
        }

        private void vulGrid(String gespeeld)
        {
            DsSoccer = wsSoccer.SelectWedstrijden(gespeeld);
            DataTable dataTable = DsSoccer.Tables.Add("wedstrijden");

            if (!gespeeld.Equals("niets"))
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = DsSoccer.Tables[0];
            }
            else
                dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nieuwe_Wedstrijd nieuw = new Nieuwe_Wedstrijd();
            nieuw.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Finales finale = new Finales();
            finale.Show();
        }

        private void cb_gespeeld_CheckedChanged(object sender, EventArgs e)
        {
            controleerVakjes();
        }

        private void cb_tespelen_CheckedChanged(object sender, EventArgs e)
        {
            controleerVakjes();
        }

        private void controleerVakjes()
        {
            if (cb_tespelen.Checked == true)
            {
                if (cb_gespeeld.Checked == true)
                    vulGrid("");
                else
                    vulGrid("nee");
            }
            else if (cb_gespeeld.Checked == true)
            {
                if (cb_tespelen.Checked == true)
                    vulGrid("");
                else
                    vulGrid("ja");
            }
            else
                vulGrid("niets");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Administrator.loggedIn())
            {
                int rowIndex = e.RowIndex;
                String wedstrijd = dataGridView1.Rows[rowIndex].Cells["match_id"].Value.ToString();
                String thuis = dataGridView1.Rows[rowIndex].Cells["team1"].Value.ToString();
                String uit = dataGridView1.Rows[rowIndex].Cells["team2"].Value.ToString();

                /*
                 * keuze formulier openen om te weten te komen om wedstrijd te bewerken of wedstrijdblad wil afdrukken
                 */
                Keuze k = new Keuze();
                k.ShowDialog();
                string keuze = k.getTerug();

                if (keuze.Equals("bewerk")) //als je de wedstrijd gegevens wil bewerken
                {
                    GespeeldeWedstrijd gespeeld = new GespeeldeWedstrijd(thuis, uit, wedstrijd);
                    if (gespeeld.ShowDialog() == DialogResult.OK)
                    {
                        vulGrid("");
                    }
                }
                else if (keuze.Equals("wedstrijdblad")) //als je het wedstrijdblad van deze wedstrijd wil afdrukken
                {
                    //printBlad();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
