using System;
using System.Windows.Controls;

namespace Personas
{
    class NavegacionService
    {
        public UserControl CargarFormulario() => new Formulario();

        public UserControl CargarLista() => new Lista();
    }
}