using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EjerciciosCap10_12AP1.UI.Cap10.Ejercicio1_Cap10;
using EjerciciosCap10_12AP1.UI.Cap10.Ejercicio2_Cap10;
using EjerciciosCap10_12AP1.UI.Cap10.Ejercicio3_Cap10;
using EjerciciosCap10_12AP1.UI.Cap10.Ejercicio4_Cap10;
using EjerciciosCap10_12AP1.UI.Cap10.Ejercicio5_Cap10;

namespace EjerciciosCap10_12AP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Cap10Button_Click(object sender, RoutedEventArgs e)
        {

            Ejercicio1Cap10 cap10 = new Ejercicio1Cap10();
            cap10.Show();
        }

        private void Ejercicio2_Cap10Button_Click(object sender, RoutedEventArgs e)
        {

            Ejercicio2Cap10 cap10_2 = new Ejercicio2Cap10();
            cap10_2.Show();
        }

        private void Ejercicio3_Cap10Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3Cap10 cap10_3 = new Ejercicio3Cap10();
            cap10_3.Show();
        }

        private void Ejercicio4_Cap10Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio4Cap10 cap10_4 = new Ejercicio4Cap10();
            cap10_4.Show();
        }

        private void Ejercicio5_Cap10Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap10 cap10_5 = new Ejercicio5Cap10();
            cap10_5.Show();
        }
    }
}
