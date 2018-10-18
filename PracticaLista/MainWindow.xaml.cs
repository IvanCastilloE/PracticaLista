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

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumnos = new List<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            Materia historia = new Materia("HST123", "Historia");
            Materia matematicas = new Materia("MAT456", "Matematicas");
            Materia civismo = new Materia("CIV789", "Civismo");
            Materia espanol = new Materia("ESP741", "Español");
            Materia artistica = new Materia("ART852", "Artistica");

            alumnos.Add(new Alumno("José Perez", "153697", "Lic. Derecho"));
            alumnos.Add(new Alumno("Juan Lopez", "054687", "Lic. Multimedia"));
            alumnos.Add(new Alumno("Kristina García", "283698", "Ing. Biomedico"));
            alumnos.Add(new Alumno("María Valencia", "859746", "Ing. Civil"));
            //PrimerAlumno
            alumnos[0].Materias.Add(espanol);
            alumnos[0].Materias.Add(artistica);
            //SegundoALumno
            alumnos[1].Materias.Add(civismo);
            alumnos[1].Materias.Add(matematicas);
            //Tercer alumno
            alumnos[2].Materias.Add(historia);
            alumnos[2].Materias.Add(espanol);
            //Cuarto Alumno
            alumnos[3].Materias.Add(civismo);
            alumnos[3].Materias.Add(artistica);
            foreach(Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(new ListBoxItem()
                {
                    Content = alumno.Nombre
                }
                );
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;

            lstMaterias.Items.Clear();
            foreach(Materia materia in alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(new ListBoxItem()
                {
                    Content = materia.Nombre
                }
                );

            }

        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstMaterias.SelectedIndex !=-1)
            {
                lblNombreMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
                lblClaveMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
            }
            
        }
    }
}
