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
    public sealed partial class partidos : Page
    {
        objetoEquipo equip1;
        objetoEquipo equip2;

        


        public partidos()
        {
            this.InitializeComponent();
            comboEquipo1.ItemsSource = listaEquipos;
            comboEquipo2.ItemsSource = listaEquipos;

        }

        public static ObservableCollection<objetoEquipo> listaEquipos = MainPage.listaEquipos;
        public static ObservableCollection<objetoPartidos> listaPartidos = MainPage.listaPartidos;

        private void clickVolver(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void comboEquipo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            objetoEquipo item = (objetoEquipo)comboEquipo1.SelectedItem;

             equip1 = item;

        }

        private void comboEquipo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            objetoEquipo item = (objetoEquipo)comboEquipo2.SelectedItem;

            equip2 = item;

        }

        private void guardarPartido_Click(object sender, RoutedEventArgs e)
        {

            objetoPartidos partido = new objetoPartidos(equip1.Nombre, equip2.Nombre);


            if (listaPartidos.Contains(partido))
            {
                textoAlert.Text = "El partido ya se ha jugado";
            }
            else
            {
                if (equip1 == null || equip2 == null)
                {
                    textoAlert.Text = "No pueden existir campos nullos";
                }
                else if (equip1 == equip2)
                {
                    textoAlert.Text = "No pueden ser el mismo equipo";
                }
                else
                {

                    listaPartidos.Add(partido);

                    String gol1 = goles_locales.Text;
                    String gol2 = goles_visitante.Text;

                    int gol_local = Convert.ToInt32(gol1);
                    int gol_visitante = Convert.ToInt32(gol2);

                    equip1.PJ++;
                    equip2.PJ++;

                    equip1.GF += gol_local;
                    equip1.GC += gol_visitante;

                    equip2.GF += gol_visitante;
                    equip2.GC += gol_local;

                    //gana local
                    if (gol_local > gol_visitante)
                    {
                        equip1.PG++;
                        equip1.PTS += 3;
                        equip2.PP++;
                        textoAlert.Text = "Gana " + equip1;

                    }
                    //gana visitante
                    else if (gol_local < gol_visitante)
                    {
                        equip2.PG++;
                        equip2.PTS += 3;
                        equip1.PP++;
                        textoAlert.Text = "Gana " + equip2;
                    }
                    //empate
                    else
                    {
                        equip1.PTS++;
                        equip2.PTS++;
                        textoAlert.Text = "Empate";
                    }

                }
            }

        }
    }
}
