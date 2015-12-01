using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CatalogueJouetPoulmane;

namespace CatalogueDeJouet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username=TBUser.Text;
            string password=TBPassword.Text;
            bool valide = Passerelle.identification(username, password);
            try
            {
                if (valide==true)
                {
                    WChoixJouet windows = new WChoixJouet();
                    windows.Show();
                    this.Close();
                }
                else
                {
                    lEtat.Content = "Nom d'utilisateur ou mot de passe incorrecte";
                    TBPassword.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Connexion impossible");
                lEtat.Content = "Connexion impossible";
            }
        }

        private void bQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TBUser_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TBPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        
    }
}
