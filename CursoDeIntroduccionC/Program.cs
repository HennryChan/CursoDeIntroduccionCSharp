using System;

namespace CursoDeIntroduccionC
{
    class Program
    {
        private void MenuPricipal()
        {
            Console.WriteLine("............Menu Pricipal.............\n");
            Console.WriteLine("Opción 1: Reto 2");
            Console.WriteLine("Opción 2: Reto 3");
            Console.WriteLine("Opción 3: Reto 4");
            Console.WriteLine("Opción 4: Reto 5");
            Console.WriteLine("Opción 5: Salir");
            Console.WriteLine("Ingrese el numero de la opcion deseada");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\n........Reto 2...........");
                    Reto_2 reto2 = new Reto_2();
                    reto2.Reto2();
                    break;
                case 2:
                    Console.WriteLine("\n........Reto 3............");
                    Reto_3 reto3 = new Reto_3();
                    reto3.Reto3();
                    break;
                case 3:
                    Console.WriteLine("\n........Reto 4.............");
                    Reto_4 reto4 = new Reto_4();
                    reto4.dividirNumeros(1, 2);
                    break;
                case 4:
                    Console.WriteLine("\n........Reto 5..............");
                    Reto_5 reto5 = new Reto_5();
                    reto5.CicloWhile();
                    reto5.ClicloForYDoWhile();
                    break;
                default:
                    break;
            }
        }

        public void RepeticionDeMenu()
        {
            string resp;
            do
            {
                MenuPricipal();
                Console.WriteLine("\n¿Desaes regresar al menu principal? si/no");
                resp = Console.ReadLine();
            } while (resp == "si");
        }

        static void Main(string[] args)
        {
            Program menu = new Program();
            menu.RepeticionDeMenu();
        }
    }
}
