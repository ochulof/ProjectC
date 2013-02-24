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
    public partial class Klassement : Form
    {

        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet dsPouleA;
        DataSet dsPouleB;


        public Klassement()
        {
            InitializeComponent();
            maakKlassement();
        }

        private void maakKlassement()
        {
            dsPouleA = wsSoccer.SelectKlassement("A");
            dsPouleB = wsSoccer.SelectKlassement("B");

            dataGridViewA.AutoGenerateColumns = true;
            dataGridViewA.DataSource = dsPouleA.Tables[0];

            dataGridViewB.AutoGenerateColumns = true;
            dataGridViewB.DataSource = dsPouleB.Tables[0];

            dataGridViewA.Columns[0].Width = 130;
            dataGridViewA.Columns[1].Width = 62;
            dataGridViewA.Columns[2].Width = 62;
            dataGridViewA.Columns[3].Width = 62;
            dataGridViewA.Columns[4].Width = 62;
            dataGridViewA.Columns[5].Width = 86;
            dataGridViewA.Columns[6].Width = 70;
            for (int i = 0; i < 7; i++)
                dataGridViewA.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewB.Columns[0].Width = 130;
            dataGridViewB.Columns[1].Width = 62;
            dataGridViewB.Columns[2].Width = 62;
            dataGridViewB.Columns[3].Width = 62;
            dataGridViewB.Columns[4].Width = 62;
            dataGridViewB.Columns[5].Width = 86;
            dataGridViewB.Columns[6].Width = 70;
            for (int i = 0; i < 7; i++)
                dataGridViewB.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
