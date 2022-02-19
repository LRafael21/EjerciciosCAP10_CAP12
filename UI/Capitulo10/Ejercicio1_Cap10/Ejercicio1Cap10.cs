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

/*Crear el diseño de una clase para llevar
el inventario de una tienda.*/

namespace EjerciciosCap10_12AP1.UI.Cap10.Ejercicio1_Cap10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Ejercicio1Cap10 : Window
    {
        public Ejercicio1Cap10()
        {
            InitializeComponent();
        }

        class InventarioTienda
        {
            public int productoId;
            public string? descripcion;
            public int costo;

            public InventarioTienda(int Id, string descrip, int cost)
            {
                productoId = Id;
                descripcion = descrip;
                costo = cost;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"ID: {productoId}\nDescripcion: {descripcion}\nCosto: {costo}");
                return sb.ToString();
            }
           

        }
        private void AgregarInventarioButton_Click(object sender, RoutedEventArgs e)
        {
            InventarioTienda inventario = new InventarioTienda
            (Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite el ID del producto", "ID del producto", " ",725,450)), Microsoft.VisualBasic.Interaction.InputBox($"Digite la descripcion del producto", "Descripcion del producto", " ", 725, 450), Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite el costo del producto", "Costo del producto", " ", 725, 450)));

            InventarioLista.Items.Add(inventario.ToString());
        }
      


       
    }
}
