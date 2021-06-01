using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace proyecto_uwp
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class clasificacion : Page
    {

        public static ObservableCollection<objetoEquipo> listaEquipos = MainPage.listaEquipos;

        public clasificacion()
        {
            this.InitializeComponent();

           List<objetoEquipo> lista = listaEquipos.ToList<objetoEquipo>();

            lista.Sort();
            lista.Reverse();

            foreach(objetoEquipo item in lista)
            {
                textNombre.Text += "\n" + "\n" + item.Nombre ;
                textProvincia.Text += "\n" + "\n" + item.Provincia ;
                textPJ.Text += "\n" + "\n" + item.PJ;
                textPG.Text += "\n" + "\n" + item.PG ;
                textPP.Text += "\n" + "\n" + item.PP ;
                textGF.Text += "\n" + "\n" + item.GF ;
                textGC.Text += "\n" + "\n" + item.GC;
                textPTS.Text += "\n" + "\n" + item.PTS ;

            }
        }

        private void botonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
