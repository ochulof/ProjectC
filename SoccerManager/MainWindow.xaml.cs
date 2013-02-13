using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SoccerManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Boolean ingelogd;
        public MainWindow()
        {
            InitializeComponent();
            setIngelogd(false);
        }
        

        private void mnu_Inloggen_Click(object sender, RoutedEventArgs e)
        {
            setIngelogd(true);
        }
        public void setIngelogd(Boolean antwoord)
        {
            ingelogd = antwoord;
            if (ingelogd)
            {
                mnu_Afmelden.Visibility = Visibility.Visible;
                mnu_Nieuw.Visibility = Visibility.Visible;
                mnu_Inloggen.Visibility = Visibility.Collapsed;
                btn_nieuwe_spelers.Visibility = Visibility.Visible;
                btn_nieuw_team.Visibility = Visibility.Visible;

            }
            else{
                mnu_Afmelden.Visibility = Visibility.Collapsed;
                mnu_Nieuw.Visibility = Visibility.Collapsed;
                mnu_Inloggen.Visibility = Visibility.Visible;
                btn_nieuwe_spelers.Visibility = Visibility.Hidden;
                btn_nieuw_team.Visibility = Visibility.Hidden;
            }
                
        }

        private void mnu_Afmelden_Click(object sender, RoutedEventArgs e)
        {
            setIngelogd(false);
        }

        /* Zowel nieuw team menu als nieuw team button verwijzen naar de windows form Nieuw_Team */

        private void mnu_nieuw_team_Click(object sender, RoutedEventArgs e)
        {
            btn_nieuw_team_Click(sender, e);
        }
        private void btn_nieuw_team_Click(object sender, RoutedEventArgs e)
        {
            Nieuw_Team nieuw = new Nieuw_Team();
            nieuw.ShowDialog();
        }




        /* Zowel nieuw speler menu als nieuwe spelers button verwijzen naar de windows form nieuwe spelers */

        private void mnu_nieuw_speler_Click(object sender, RoutedEventArgs e)
        {
            btn_nieuwe_spelers_Click(sender, e);
        }

        private void btn_nieuwe_spelers_Click(object sender, RoutedEventArgs e)
        {
            Nieuwe_Speler nieuw = new Nieuwe_Speler();
            nieuw.ShowDialog();
        }



        private void mnu_Wedstrijdschema_Click(object sender, RoutedEventArgs e)
        {
            btn_wedstrijdschema_Click(sender, e);
        }
        private void btn_wedstrijdschema_Click(object sender, RoutedEventArgs e)
        {
            Wedstrijdschema nieuw = new Wedstrijdschema();
            nieuw.Show();
        }

       
        private void btn_klassement_Click(object sender, RoutedEventArgs e)
        {
            Klassement nieuw = new Klassement();
            nieuw.Show();
        }

        private void mnu_teams_Click(object sender, RoutedEventArgs e)
        {
            btn_teams_Click(sender, e);
        }
        private void btn_teams_Click(object sender, RoutedEventArgs e)
        {
            Teams nieuw = new Teams();
            nieuw.ShowDialog();
        }

        private void mnu_spelerslijst_Click(object sender, RoutedEventArgs e)
        {
            btn_spelerslijst_Click(sender, e);
        }
        private void btn_spelerslijst_Click(object sender, RoutedEventArgs e)
        {
            Spelerslijst nieuw = new Spelerslijst();
            nieuw.Show();
        }
        private void mnu_nieuw_wedstrijd_Click(object sender, RoutedEventArgs e)
        {
            Nieuwe_Wedstrijd nieuw = new Nieuwe_Wedstrijd();
            nieuw.ShowDialog();
        }
        private void mnu_afsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mnu_Finale_Click(object sender, RoutedEventArgs e)
        {
            Finales finale = new Finales();
            finale.Show();
        }

        private void mnu_Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hulp is onderweg");
        }
    }

}
