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
// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace proyecto_uwp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class equipos : Page
    {

       public static  ObservableCollection<objetoEquipo> listaEquipos = MainPage.listaEquipos;
        String provincia;
        public equipos()
        {
            this.InitializeComponent();
            llenarComboBox();
            

        }

        public List<String> provincias = new List<string>();

        public void llenarComboBox()
        {
            provincias.Add("Sevilla");
            provincias.Add("Cádiz");
            provincias.Add("Córdoba");
            provincias.Add("Granada");
            provincias.Add("Málaga");
            provincias.Add("Huelva");
            provincias.Add("Almería");
            provincias.Add("Jaén"); ;
            comboProvincias.ItemsSource = provincias;
        }

        private void clickGuardar(object sender, RoutedEventArgs e)
        {
            String nombreE = nombre.Text;

            objetoEquipo equipo = new objetoEquipo(nombreE, provincia);


            

                if (listaEquipos.Contains(equipo))
            {
                textAlert.Text = "El equipo ya existe";
            }
            else
            {
                listaEquipos.Add(equipo);
                textAlert.Text = "Equipo creado";
                
            }
                

       
            

        }

        private void clcikVolver(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void comboProvincias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = (string)comboProvincias.SelectedItem;

            provincia = item;
            
        }
    }
    
}
