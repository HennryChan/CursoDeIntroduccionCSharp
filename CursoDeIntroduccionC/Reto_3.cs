using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDeIntroduccionC
{
    public class Reto_3
    {
        public void Reto3()
        {

            Console.WriteLine("Uso del metodo Trim()");
            string tex = " Hola ";
            Console.WriteLine("Frase " + tex);
            Console.WriteLine("Resultado: " + tex.Trim());

            Console.WriteLine("\nUso del metodo Split()");
            string tex1 = "01/05/2022";
            Console.WriteLine("Frase: " + tex1);
            Console.WriteLine("Resultados: ");
            string[] split = tex1.Split(new char[] { '/' });
            Console.WriteLine("Dia: " + split[0]);
            Console.WriteLine("Mes: " + split[1]);
            Console.WriteLine("Año: " + split[2]);

            Console.WriteLine("\nUso del metodo Remplace()");
            string text2 = "Nombre Apellido Ejercicio1";
            Console.WriteLine("Frase: " + text2);
            Console.WriteLine("Resultado: " + text2.Replace(" ", "_"));

            Console.WriteLine("\nUso del metodo Contains()");
            string text3 = "Verdadero";
            string text4 = "Verdadero";
            Console.WriteLine("Frase 1: " + text3 + "\nFrase 2: " + text4);
            Console.WriteLine("Resultado: " + text3.Contains(text4));

            Console.WriteLine("\nUso del metodo StartsWith()");
            string tex5 = "Hola";
            string tex6 = "Ola";
            Console.WriteLine("Frase 1: " + tex5 + "\nFrase 2: " + tex6);
            Console.WriteLine("Resultado: " + tex5.StartsWith(tex6));
        }
    }
}
