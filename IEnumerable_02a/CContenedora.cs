using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_02a
{
    class CContenedora : IEnumerable
    {
        private int[] Valores = new int[10];
        int N;

        public CContenedora()
        {
            for (int N = 0; N < 10 ; N++)
            Valores[N] = N * N;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return (new ContenedorEnum(Valores));
        
        }

         

    }
}
