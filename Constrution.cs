using System;

namespace exerciceC_
{
    public class Constrution
    {
        
        // Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. En el constructor cargar los atributos y luego en otro método imprimir sus datos y 
        // por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)

        private string empleado;
        private int sueldo;
        public Constrution(){
            
            Console.WriteLine("ingrese empleado");
            empleado = Console.ReadLine();

            Console.WriteLine("ingrese saldo");
            sueldo = Convert.ToInt32(Console.ReadLine());
        }

        public void inpuestos(){

            if(sueldo > 3000)
            {
                Console.WriteLine($"el sueldo del empleado es {empleado}" );
            }
        }

    }
}