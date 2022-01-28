﻿using Proyecto_de_inscripcion.UI.Registros;
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

namespace Proyecto_de_inscripcion
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

        private void RegistroUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios usuario = new rUsuarios();
            usuario.Show();
        }

        private void RegistroEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.Show();
        }

        private void RegistroIncripcionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rInscripcion inscripcion = new rInscripcion();
            inscripcion.Show();
        }

        private void RegistroProfesoresMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProfesores profesores = new rProfesores();
            profesores.Show();
        }

        private void RegistroCursosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCursos cursos = new rCursos();
            cursos.Show();
        }

        private void RegistroAreasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rAreas areas = new rAreas();
            areas.Show();
        }

        private void RegistroMateriasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rMaterias materias = new rMaterias();
            materias.Show();
        }
    }
}
