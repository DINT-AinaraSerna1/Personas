﻿using Personas.Vistas.Lista;
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
    /// Lógica de interacción para Lista.xaml
    /// </summary>
    public partial class Lista : UserControl
    {
        private ListaVM vmLista;
        public Lista()
        {
            InitializeComponent();
            vmLista = new ListaVM();
            DataContext = vmLista;
        }
    }
}
