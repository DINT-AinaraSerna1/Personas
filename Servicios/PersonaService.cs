using Personas.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicio
{
    class PersonaService
    {
        public static ObservableCollection<Persona> GetSamples() 
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>
            {
                new Persona("Juan", 28, "Portuguesa"),
                new Persona("Lucas", 35, "Española"),
                new Persona("Paola", 52, "Italiana")
            };
            return lista;
        }
    }
}
