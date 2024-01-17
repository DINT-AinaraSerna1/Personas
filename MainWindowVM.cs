using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personas.modelo;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        private UserControl contenidoVista;
        public UserControl ContenidoVista
        {
            get => contenidoVista;
            set => SetProperty(ref contenidoVista, value);
        }

        public RelayCommand Vista1Command { get; }
        public RelayCommand Vista2Command { get; }

        private NavegacionService servicioUserControl;

        private ObservableCollection<Persona> listaPersona;
        public ObservableCollection<Persona> ListaPersona
        {
            get => listaPersona;
            set => SetProperty(ref listaPersona, value);
        }

        private Nacionalidad[] nacionalidades;
        public Nacionalidad[] Nacionalidades
        {
            get => nacionalidades;
            set => SetProperty(ref nacionalidades, value);
        }

        public MainWindowVM() 
        {
            servicioUserControl = new NavegacionService();
            Vista1Command = new RelayCommand(CargaFormaulario);
            Vista2Command = new RelayCommand(CargaLista);
            Nacionalidades = (Nacionalidad[])Enum.GetValues(typeof(Nacionalidad));
        }

        private void CargaLista()
            => ContenidoVista = servicioUserControl.CargarLista();

        private void CargaFormaulario()
            => ContenidoVista = servicioUserControl.CargarFormulario();
    }
}