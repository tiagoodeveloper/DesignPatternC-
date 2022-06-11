using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight
{
    class Piano
    {
        public void Toca(IList<INota> notas)
        {
            foreach (var nota in notas)
            {
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}
