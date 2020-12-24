using System;

namespace exerciceC_
{
    public class construcionTwocs
    {
        //Implementar la clase operaciones. Se deben cargar dos valores enteros en el constructor, calcular su suma, resta,
        // multiplicación y división, cada una en un método, imprimir dichos resultados.

        private int numberOne;
        private int numberTwo;

        public construcionTwocs()
        {

            Console.WriteLine("ingrese el valor 1");
            numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese el valor 2");
            numberTwo = Convert.ToInt32(Console.ReadLine());
        }

        public void operacion()
        {
            int val = 0;
            Console.WriteLine("ingrese 1 suma ");
            Console.WriteLine("ingrese 2 resta ");
            Console.WriteLine("ingrese 3 multiplicacion ");
            Console.WriteLine("ingrese 3 division ");
            Console.WriteLine("ingrese operacion ");
            val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    int suma = numberOne + numberTwo;
                    Console.WriteLine("la suma es" + suma);
                    break;

                case 2:
                    int resta = numberOne - numberTwo;
                    Console.WriteLine("la resta es" + resta);
                    break;

                case 3:
                    int multiplicacion = numberOne * numberTwo;
                    Console.WriteLine("la resta es" + multiplicacion);
                    break;

                case 4:
                    int division = numberOne / numberTwo;
                    Console.WriteLine("la resta es" + division);
                    break;

                default:
                    Console.WriteLine("ingrese numero correcto");
                    break;
            }

        }
    }
}