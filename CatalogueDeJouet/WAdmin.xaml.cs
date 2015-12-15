using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace CatalogueDeJouet
{
    /// <summary>
    /// Logique d'interaction pour WAdmin.xaml
    /// </summary>
    public partial class WAdmin : Window
    {
        public WAdmin()
        {

            InitializeComponent();
            SqlDataAdapter adaptateur;
            DataSet modif;
            adaptateur = new SqlDataAdapter("select * from CommandePasser", Passerelle.connexionSeul());
            modif = new DataSet();
            adaptateur.Fill(modif);
            datagrid1.ItemsSource = modif.Tables[0].DefaultView;
        }
    }
}

