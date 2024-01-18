using Personas.modelo;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para Formulario.xaml
    /// </summary>
    public partial class Formulario : UserControl
    {
        private FormularioVM vmForm;
        public Formulario()
        {
            InitializeComponent();
            vmForm = new FormularioVM();
            DataContext = vmForm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string nombre = nombreTextBox.Text;
            bool edadParseada = int.TryParse(edadTextBox.Text, out int edad);
            if (nombre != string.Empty && edadParseada && nacionalidadComboBox.SelectedIndex != -1)
            {
                string nacionalidad = nacionalidadComboBox.SelectedItem.ToString();
                vmForm.AñadirPersona(nombre, edad, nacionalidad);
            }
            nombreTextBox.Text = edadTextBox.Text = string.Empty;
            nacionalidadComboBox.SelectedIndex = -1;
        }
    }
}
