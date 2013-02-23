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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace SoccerManager
{
    /// <summary>
    /// /// Interaction logic for Inloggen.xaml
    /// </summary>
    public partial class Inloggen : Window
    {
        
        public Inloggen()
        {
            InitializeComponent();
           
        }

        private void btn_Inloggen_Click(object sender, RoutedEventArgs e)
        {
            //Connection String Wim
           //string connStr = "Data Source=.\\SQLEXPRESS1;AttachDbFilename=C:\\databank\\SoccerManager.mdf;Integrated Security=True;Connect Timeout=30";
            
            //Connection String Stef
            //string connStr = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\databank\\SoccerManager.mdf;Integrated Security=True;Connect Timeout=30";

            //Connection String Stijn
            string connStr = "Data Source=.;AttachDbFilename=C:\\databank\\SoccerManager.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(connStr);

            con.Open();

           string str = "select count(*)from Users where Gebruikersnaam='" + txt_Gebruikersnaam.Text + "' and Paswoord ='" + txt_Paswoord.Text +"'";

            SqlCommand com = new SqlCommand(str, con);

            int count = Convert.ToInt32(com.ExecuteScalar());
            if (count > 0)
            {
                Administrator.logIn();
                DialogResult = true;
            }
            else
                MessageBox.Show("foute inloggegevens");
                  
        }
    }
}
