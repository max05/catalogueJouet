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
using System.Windows.Shapes;
using System.Collections;
using CatalogueJouetPoulmane;

namespace CatalogueDeJouet
{
    /// <summary>
    /// Logique d'interaction pour WChoixJouet.xaml
    /// </summary>
    public partial class WChoixJouet : Window
    {
        int nbEnfant = 2;
        int enfantActuel = 1;
        public WChoixJouet()
        {
            InitializeComponent();
            ArrayList listeJouets= Passerelle.lesJouets();
            foreach (CatalogueJouetPoulmane.Jouet unjouet in listeJouets)
            {
                CBChoixJouet.Items.Add(unjouet.getLibelle());
            }
            
        }

        private void CBChoixJouet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bValider_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Envoyer!");
        }
    }
}
