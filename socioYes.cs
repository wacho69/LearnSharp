using System;

namespace exerciceC_
{
    public class SocioYes
    {

        // Plantear una clase Club y otra clase Socio.
        //La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). 
        //En el constructor pedir la carga del nombre y su antigüedad.
        //La clase Club debe tener como atributos 3 objetos de la clase Socio.
        //Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
        private string Name;
        private int years;
        public SocioYes()
        {

         Console.WriteLine("ingrese name");
         Name = Console.ReadLine();
         Console.WriteLine("ingrese years");
         years = Convert.ToInt32(Console.ReadLine());
         
        }

        public void Imprimir() 
        {
            Console.WriteLine( Name + " tiene una antiguedad de " + years);
        }

        public int RetornarAntiguedad()
        {
            return years;
        }

    }
}