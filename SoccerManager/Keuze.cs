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
    public partial class Keuze : Form
    {
        string terug;

        public Keuze()
        {
            InitializeComponent();
            terug = "";
        }

        //haal de geselecteerde keuze op
        public string getTerug()
        {
            return terug;
        }

        //keuze om de wedstrijd gegevens te bewerken
        private void button1_Click_1(object sender, EventArgs e)
        {
            terug = "bewerk";
            this.Close();
        }

        //keuze om het wedstrijdblad af te drukken
        private void button2_Click_1(object sender, EventArgs e)
        {
            terug = "wedstrijdblad";
            this.Close();
        }
    }
}
