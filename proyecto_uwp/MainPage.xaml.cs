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
using System.Collections.ObjectModel;
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace proyecto_uwp
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public static ObservableCollection<objetoEquipo> listaEquipos = new ObservableCollection<objetoEquipo>();
        public static ObservableCollection<objetoPartidos> listaPartidos = new ObservableCollection<objetoPartidos>();

        public MainPage()
        {
            this.InitializeComponent();
           
        }


        


        private void clickEquipo(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(equipos));
        }

        private void clickPartido(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(partidos));

        }

        private void clickTabla(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(clasificacion));
        }
    }
}
