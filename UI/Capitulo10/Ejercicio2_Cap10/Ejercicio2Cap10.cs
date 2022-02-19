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

/*2 Crear una clase para llevar la
información de los estudiantes de una
escuela*/

namespace EjerciciosCap10_12AP1.UI.Cap10.Ejercicio2_Cap10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Ejercicio2Cap10 : Window
    {
        public Ejercicio2Cap10()
        {
            InitializeComponent();
        }
        class RegistroEstudiantes
        {
            public string Nombre;
            public string Apellido;
            public int Edad;
            public int Matricula;
           

            public RegistroEstudiantes(string name, string lastName, int age, int mat)
            {
                Nombre = name;
                Apellido = lastName;
                Edad = age;
                Matricula = mat;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Nombre: {Nombre}\nApellido: {Apellido} \nEdad: {Edad}\nMatricula:{Matricula} ");
                return sb.ToString();
            }


        }
        private void AgregarEstudianteButton_Click(object sender, RoutedEventArgs e)
        {
            RegistroEstudiantes estudiantes = new RegistroEstudiantes
            (Microsoft.VisualBasic.Interaction.InputBox($"Digite el Nombre del Estudiante", "Nombre del Estudiante", " ", 725, 450), Microsoft.VisualBasic.Interaction.InputBox($"Digite Apellido del Estudiante", "Apellido del Estudiante", " ", 725, 450), Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Edad del Estudiante", "Edad del Estudiante", " ", 725, 450)), Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite la Matricula", "Matricula","",725,450)));

            EstudiantesLista.Items.Add(estudiantes.ToString());
        }
    }
}
