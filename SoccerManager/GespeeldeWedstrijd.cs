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
        public GespeeldeWedstrijd()
        {
            InitializeComponent();
            maakTabellen();
            setLabels();
        }

       
        public GespeeldeWedstrijd(string thuis, string uit)
        {
            InitializeComponent();
            //label1.Text = wedstrijd;
            lbl_thuis.Text = thuis;
            lbl_uit.Text = uit;
           // maakTabellen();
           // setLabels();
           // setNumerics();
        }

        private void setNumerics()
        {
            throw new NotImplementedException();
        }

        private void setLabels()
        {
            throw new NotImplementedException();
        }

        private void maakTabellen()
        {
            throw new NotImplementedException();
        }

    }
}
