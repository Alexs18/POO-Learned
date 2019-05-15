using System;
using System.Collections.Generic;
using System.Text;
using CLaseAves.clase;
using CLaseAves.folder;


namespace CLaseAves
{
    class Program
    {

        static void Main(string[] args)

        {
            //  Ave Objeto = new Ave(23, 100, "rojo");
            // Console.WriteLine("Ave creada tamaño{0}, tamaño {1}, color{2}", Objeto.tamano, Objeto.peso, Objeto.color);/*
            List<Ave> ListaDeAve = new List<Ave>();
            List<ciclovida1> ListaDeciclovida1 = new List<ciclovida1>();


            Aguila aguilainst = new Aguila(129, 210, "mporado", "macho");
          //  Aguila agui = new Aguila(40, 200, " Verde", " Canibal ");
            Console.WriteLine(" Aguila creada tamaño {0}, peso {1}, color {2}, tipo{3}", aguilainst.tamano, aguilainst.peso, aguilainst.color, aguilainst.tipo);           



            Console.WriteLine(aguilainst.Volar());
            Console.WriteLine(aguilainst.Sonido());

            // polimorfismo ambas clases mismo metodo, pero con distintas respuestas
            Pollo Pio = new Pollo(10, 20, "Amarillo","Driff");

        //  Console.WriteLine("Pollo creado tamaño {0}, peso {1}, color{2}, nombre{3}", Pio.tamano, Pio.peso, Pio.color);
            Console.WriteLine(Pio.Cocinar()) ;
            Console.WriteLine(Pio.Sonido()) ;

            ListaDeAve.Add(aguilainst);
            ListaDeAve.Add(Pio);
            foreach ( Ave item in ListaDeAve)// para recorrer todos los elementos que se han creado en una lista 
            {
                Console.WriteLine(item.Sonido());
            }
            ListaDeciclovida1.Add(aguilainst);
            ListaDeciclovida1.Add(Pio);
            foreach  ( ciclovida1 item in ListaDeciclovida1)
            {
                item.nacer();
                item.comer();
                item.morir();
            }
            Console.ReadKey();
           

        }
    }
}
