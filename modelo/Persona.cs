﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.modelo
{
    class Persona : ObservableObject
    {
        private string nombre;
        private int edad;
        private string nacionalidad;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        public int Edad
        {
            get => edad;
            set => SetProperty(ref edad, value);
        }
        public string Nacionalidad 
        { 
            get => nacionalidad;
            set => SetProperty(ref nacionalidad, value);
        }

        public Persona() { }
        public Persona(string nombre, int edad, string nacionalidad) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }
    }
}
