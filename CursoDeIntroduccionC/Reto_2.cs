using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDeIntroduccionC
{
    public class Reto_2
    {
        public void Reto2()
        {
            string[] coffeTrypes;
            float[] coffePrices;

            coffeTrypes = new string[] { "Expreso", "Largo", "Filtrado", "Latte" };
            coffePrices = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(coffeTrypes[i] + " coffe $" + coffePrices[i]);
            }
        }
    }
}
