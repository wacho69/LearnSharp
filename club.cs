using System;

namespace exerciceC_
{
    public class club
    {
        // Plantear una clase Club y otra clase Socio.
        //La clase Socio debe tener los siguientes atributos privados: nombre y la antigüedad en el club (en años). 
        //En el constructor pedir la carga del nombre y su antigüedad.
        //La clase Club debe tener como atributos 3 objetos de la clase Socio.
        //Definir una responsabilidad para imprimir el nombre del socio con mayor antigüedad en el club.
        private SocioYes socio1, socio2, socio3;
        public club (){

            socio1= new SocioYes(); 
            socio2= new SocioYes(); 
            socio3= new SocioYes(); 
        }

    public void responsabilidad(){
        
        Console.Write("Socio con mayor antiguedad:");
            if (socio1.RetornarAntiguedad() > socio2.RetornarAntiguedad() &&
                socio1.RetornarAntiguedad() > socio3.RetornarAntiguedad())
            {
                socio1.Imprimir();
            }
            else
            {
                if (socio2.RetornarAntiguedad() > socio3.RetornarAntiguedad())
                {
                    socio2.Imprimir();
                }
                else
                {
                    socio3.Imprimir();
                }
            }

    }
    
    }
    
}