using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class NacionalidadService
    {
        public static ObservableCollection<string> GetSamples() 
        {
            ObservableCollection<string> lista = new ObservableCollection<string>
            {
                "Española",
                "Portuguesa",
                "Italiana"
            };
            return lista;
        }
    }
}
