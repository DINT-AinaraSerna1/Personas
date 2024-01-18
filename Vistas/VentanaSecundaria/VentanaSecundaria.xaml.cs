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
using System.Windows.Shapes;

namespace Personas
{
    public partial class VentanaSecundaria : Window
    {
        private VentajaSecundariaVM vmSec;
        public VentanaSecundaria()
        {
            InitializeComponent();
            vmSec = new VentajaSecundariaVM();
            DataContext = vmSec;
        }

        private void AceptarSecundarioButton_Click(object sender, RoutedEventArgs e)
        {
            string nacionalidadNueva = nacionalidadNuevaTextBox.Text;
            vmSec.AñadirNacionalidad(nacionalidadNueva);
            DialogResult = true;
        }
    }
}
