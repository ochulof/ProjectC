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
     
                        DialogResult = true;

                  
        }
    }
}
