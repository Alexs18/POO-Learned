using System;
using System.Collections.Generic;
using System.Text;
using CLaseAves.folder;

namespace CLaseAves.clase
{
    public 
    class Pollo : Ave, 
        ciclovida1 // de esta manera esta dandole los valores de la clase aves a la clase pollo 
    {
        private String  Nombre;

        public String nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        // las interfaces en si contiene un contrato
        public Pollo(int tamano, int peso, string color, String nombre ) : base(tamano, peso, color)
        {
            this.Nombre = nombre;

        }
        public string Cocinar()
        {
            return "este pollo se esta cocinando";
            // override aignifica sobreescribir 
        }
        public override string Sonido()
        {
            return "pio";
        }

        public void nacer()
        {
            Console.WriteLine("POLLO NACIENDO");
        }

        public void comer()
        {
            Console.WriteLine("POLLO CRECIENDO ");
        }

        public void morir()
        {
            Console.WriteLine("POLLO MURIENDO");
        }
    }
}
