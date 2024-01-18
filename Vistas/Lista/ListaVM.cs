using CommunityToolkit.Mvvm.ComponentModel;
using Personas.modelo;
using Personas.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vistas.Lista
{
    class ListaVM : ObservableObject
    {
        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get => listaPersonas;
            set => SetProperty(ref listaPersonas, value);
        }

        public ListaVM()
        {
            listaPersonas = PersonaService.GetSamples();
        }
    }
}
