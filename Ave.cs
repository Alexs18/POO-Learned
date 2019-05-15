using System;
using System.Collections.Generic;
using System.Text;

namespace CLaseAves.clase
{
    public abstract // se realiza de forma abstracta, para que no todos tengan los mismsos sonidos , y diferenciarlos

        class Ave
    {

        private int Tamano;

        public int tamano
        {
            get { return Tamano; }
            set { Tamano = value; }
        }
        private int Peso;

        public int peso
        {
            get { return Peso; }
            set { Peso = value; }
        }
        private String Color;

        public Ave(int tamano, int peso, string color)
        {
            this.tamano = tamano;
            this.peso = peso;
            this.color = color;
        }

        public String color
        {
            get { return Color; }
            set { Color = value; }
        }
        public abstract String Sonido();// cuando es virtual el metodo se puede sobreescribir 
       




    }
}
