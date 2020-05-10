using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Dizi<T>
    {
        public Dizi(int elemanSayisi)
        {
            elemanlar = new T[elemanSayisi];
        }

        public T[] elemanlar { get; set; }

        int i = 0;

        public void Ekle(T eleman)
        {
            elemanlar[i] = eleman;
            i++;
        }
    }
}