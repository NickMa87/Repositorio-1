using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IEnumerable_02a
{
    class ContenedorEnum : IEnumerator 
    {
        public int[] Arreglo;
        private int Posicion = -1;


        public ContenedorEnum(int[] pArreglo)
        {
            Arreglo = pArreglo;
        }

        public bool MoveNext()
        {
            Posicion+=2;
            if (Posicion < Arreglo.Length)
                return true;
            else
                return false;        
        }

        public void Reset()
        {
            Posicion = -1;
        }

        public object Current
        {
            get
            {
                return Arreglo[Posicion];
            }
        }



    }
}
