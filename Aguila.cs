using System;
using System.Collections.Generic;
using System.Text;
using CLaseAves.folder;

namespace CLaseAves.clase
{

    public class Aguila : Ave, ciclovida1
    // manera de wue los atributos de la clase ave se vallan a la clase aguila.....
    {
        private String
            Tipo;

        public String
            tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        public int edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Aguila(int tamano, int peso, string color, String tipo) : base(tamano, peso, color)
        {
            this.Tipo = tipo; // adicionamos el tipo al atributo
        }
        public String Volar() // este metodo solo sirve para el aguila
        {
        return "EL AVE ESTA VOLANDO";
        }
        public override string Sonido()
        {
            return "ZZZ";
        }

        public void nacer()
        {
            Console.WriteLine("NACIENDO");// para que funcione tienes que enviarle un msj o en otras palabras instanciarlo 
        }

        public void comer()
        {
            Console.WriteLine("comiendo");
        }

        public void morir()
        {
            Console.WriteLine("Muriendo");
        }
    }
}

