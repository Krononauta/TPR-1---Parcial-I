using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPR_1___Parcial
{
    class TCola
    {
        const int max = 100;
        int Primero;
        int Ultimo;
        TAlumno[] Cola = new TAlumno[max];

        public TCola()
        {
           // Cola = new int[size];
            Primero = 0;
            Ultimo = -1;
            //max = size;
        }  
        public int Primero_()
        {
            return Primero;
        }
        public int Ultimo_()
        {
            return  Ultimo;
        }
        public bool Vacia()
        {
            return (Primero == Ultimo + 1);
        }
        public bool Llena()
        {
            return (Ultimo == max - 1);
        }

        public void Enqueue(TAlumno item)
        {
       
            if (Ultimo < max - 1)
            {
                Cola[++Ultimo] = item;
            }


        }

        public TAlumno Dequeue()
        {
            return Cola[Primero++];
        }
        public TAlumno[] Elementos()
        {
            return Cola;
        }

        public int Longitud()
        {
            return Ultimo;
        }

        public TAlumno Peek()
        {
            return Cola[Primero];
        }
        public void printQueue()
        {
            if (Primero == Ultimo + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = Primero; i <= Ultimo; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + Cola[i]);
                }
            }
        }
    }
}
