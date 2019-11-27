using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GestionnaireBDD;
using ClassesMetier;
using Windows.UI.Popups;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPGestionSalles
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        GstBdd GstBdd;

        private async void btnReserver_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GstBdd = new GstBdd();
            lstManifs.ItemsSource = GstBdd.GetAllManifestations();
            lstTarifs.ItemsSource = GstBdd.GetAllTarifs();
        }

        private void lstManifs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstManifs.SelectedItem != null)
            {
                gvPlaces.ItemsSource = GstBdd.GetAllPlacesByIdManifestation((lstManifs.SelectedItem as Manifestation).IdManif, idSalle:(lstManifs.SelectedItem as Manifestation).LaSalle.IdSalle);
            }
        }

        private async void gvPlaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtTotal;
        }
    }
}
