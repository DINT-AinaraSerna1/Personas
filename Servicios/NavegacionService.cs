using System;
using System.Windows.Controls;

namespace Personas
{
    class NavegacionService
    {
        VentanaSecundaria ventanaSecundaria;

        public NavegacionService() 
            => ventanaSecundaria = new VentanaSecundaria();

        public void AbrirVentana() 
            => ventanaSecundaria.ShowDialog();

        public UserControl CargarFormulario() => new Formulario();

        public UserControl CargarLista() => new Lista();
    }
}