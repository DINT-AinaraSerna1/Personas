using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personas.modelo;
using Personas.Servicio;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        private UserControl? contenidoVista;
        public UserControl? ContenidoVista
        {
            get => contenidoVista;
            set => SetProperty(ref contenidoVista, value);
        }

        public RelayCommand Vista1Command { get; }
        public RelayCommand Vista2Command { get; }

        private NavegacionService servicioUserControl = new NavegacionService();

        public MainWindowVM() 
        {
            Vista1Command = new RelayCommand(CargaFormulario);
            Vista2Command = new RelayCommand(CargaLista);
        }

        private void CargaLista()
            => ContenidoVista = servicioUserControl.CargarLista();

        private void CargaFormulario()
            => ContenidoVista = servicioUserControl.CargarFormulario();
    }
}