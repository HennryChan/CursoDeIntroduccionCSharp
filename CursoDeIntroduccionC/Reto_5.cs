using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDeIntroduccionC
{
    public class Reto_5
    {
        public void ClicloForYDoWhile()
        {
            int a = 0;
            string opcion;

            do
            {
                Console.WriteLine("Ingresa el numero de la tabla de multiplicación");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    a += num;
                    Console.WriteLine(i + "X" + num + "= " + a);
                }

                Console.WriteLine("¿Deseas seguir? Opcion 1 = no, Opción 2= si");
                opcion = Console.ReadLine();
            } while (opcion == "si");
        }


        public void CicloWhile()
        {
            int contador = 0;

            Console.WriteLine("Ingresa un numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nContador");

            while (contador < num)
            {
                contador += 1;
                Console.WriteLine(contador);
            }
        }
    }
}
