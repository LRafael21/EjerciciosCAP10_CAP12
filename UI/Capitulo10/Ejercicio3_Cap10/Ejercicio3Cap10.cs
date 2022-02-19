using System;
using System.Windows;
using System.Text;


namespace EjerciciosCap10_12AP1.UI.Cap10.Ejercicio3_Cap10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Ejercicio3Cap10 : Window
    {
        public Ejercicio3Cap10()
        {
            InitializeComponent();
        }

        class Poligonos
        {
            public int numDeDiagonales;
            public int lado;

            public int b;
            public int h;
            public int area;


            public Poligonos(int lados)
            {
                lado = lados;

            }
            public Poligonos(int bas, int altura)
            {
                b = bas;
                h = altura;
            }
            
            public void CalcularAreaTriangulo()
            {
                area = (b * h) / 2;
            }
            public void CalcularNumDiagonales()
            {
                numDeDiagonales = lado * (lado - 3) / 2;
            }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"La altura del triangulo es {h} La base es: {b} y el area es: {area}");
                return sb.ToString();
            }

        }

        public void AgregarPoligonoButton_Click(object sender, RoutedEventArgs e)
        {
            

            Poligonos triangulo = new Poligonos(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite la base de su rectangulo", "Base", " ", 0)), Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Digite la altura de su triangulo", "Altura", " ", 0)));
           
            triangulo.CalcularAreaTriangulo();
            PoligonosLista.Items.Add(triangulo.ToString());
            
           
        }
    }
}
