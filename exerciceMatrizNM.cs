using System;

namespace exerciceC_
{
    public class exerciceMatrizNM
    {
        public int[,]element;
        public void ingresar(){
            
        Console.Write("Cuantas fila tiene la matriz:");
        int filas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("cuantas columnas tiene la matriz");
        int columnas = Convert.ToInt32(Console.ReadLine());
        element = new int[filas,columnas];


        for(int f = 0; f < element.GetLength(0);f++){
            for(int c = 0; c < element.GetLength(1); f++){

                Console.WriteLine("ingrese los elementos");
                element[f,c] = Convert.ToInt32(Console.ReadLine());
            }

        }
    }


   }
}