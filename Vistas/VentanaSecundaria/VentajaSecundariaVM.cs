using CommunityToolkit.Mvvm.ComponentModel;
using Personas.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    class VentajaSecundariaVM : ObservableObject
    {
        public VentajaSecundariaVM() 
        {
        
        }

        public void AñadirNacionalidad(string nacionalidadNueva)
        {
            FormularioVM vmForm = new FormularioVM();
            vmForm.Nacionalidades.Add(nacionalidadNueva);
            MessageBox.Show("Queda implementar añadir nueva nacionalidad a la lista por mensajería'", "Nacionalidad");
        }
    }
}
