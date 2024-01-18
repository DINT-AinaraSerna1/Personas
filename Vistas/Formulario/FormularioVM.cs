using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personas.modelo;
using Personas.Servicios;
using Personas.Vistas.Lista;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class FormularioVM : ObservableObject
    {
        public RelayCommand AbrirVentanaCommand { get; }
        private NavegacionService? servicioUserControl;


        private ObservableCollection<string> nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get => nacionalidades;
            set => SetProperty(ref nacionalidades, value);
        }

        public FormularioVM() 
        {
            AbrirVentanaCommand = new RelayCommand(AbrirVentana);
            nacionalidades = NacionalidadService.GetSamples();
        }

        private void AbrirVentana()
        {
            servicioUserControl = new NavegacionService();
            servicioUserControl.AbrirVentana();
        }

        public void AñadirPersona(string nombre, int edad, string nacionalidad)
        {
            ListaVM listaVM = new ListaVM();
            listaVM.ListaPersonas.Add(
                new Persona(nombre, edad, nacionalidad)
            );
            // Comunicar a la Vista "Lista" por "mensajería".
            MessageBox.Show("Queda implementar añadir nueva persona a la lista por mensajería'", "Persona añadida");
        }
    }
}
