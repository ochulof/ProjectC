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
    public partial class Spelerslijst : Form
    {

        SoccerWebservice.SoccerManager_WebserviceSoapClient wsSoccer = new SoccerWebservice.SoccerManager_WebserviceSoapClient();
        DataSet DsSoccer;
              
        
        public Spelerslijst()
        {
            InitializeComponent();
             GetTable();
            

            
        }
        private void GetTable()
        {
            DsSoccer = wsSoccer.SelectSpelerGegevens();
            DataTable dataTable = DsSoccer.Tables.Add("spelers");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = DsSoccer.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
