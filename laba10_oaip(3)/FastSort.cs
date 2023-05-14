using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_oaip_3_
{
    internal class FastSort : IMethodOfSort
    {
        public string Sortedmas = "", sortedmasrav = ""; public int srav=0, pere=0; public Stopwatch stopwatch = new Stopwatch();
        public List<int> array;
        public List<int> Sort(List<int> mas)
        {
            stopwatch.Start();
            array = mas;
            QuickSort(array, 0, array.Count);
            stopwatch.Stop();
            return array;
        }
        public void QuickSort(List<int> mas, int a, int b)
        {
            int i = a;
            int j = b;
            j--;
            int middle = array[(a + b) / 2];
            while (i <= j)
            {
                while (array[i] < middle)
                {
                    i++;
                }
                while (array[j] > middle)
                {
                    j--;
                }
                sortedmasrav += $"{mas[i]} & {mas[j]} сравниваются\n";
                if (i <= j)
                {
                    int temporaryVariable = array[i];
                    array[i] = array[j];
                    array[j] = temporaryVariable;
                    Sortedmas += $".{mas[i]} и {mas[j]}.\nСостояние массива: ";
                    sortedmasrav += $".{mas[i]} и {mas[j]}.\nСостояние массива: ";
                    for (int e = 0; e < mas.Count; e++)
                    {
                        Sortedmas += mas[e].ToString();
                        Sortedmas += " ";
                        sortedmasrav += mas[e].ToString() + " ";
                    }
                    Sortedmas += "\n";
                    sortedmasrav += "\n";
                    pere++;
                    i++;
                    j--;
                    
                }
                
                srav++;
            }
            if (a < j)
            {
                QuickSort(array, a, j);
            }
            if (i < b)
            {
                QuickSort(array, i, b);
            }
        }
        public int[] GetSrPere()
        {
            int[] need = { srav, pere };
            return need;
        }
        public Stopwatch GetTime()
        {
            return stopwatch;
        }
        public string[] GetConsole()
        {
            string[] a = { Sortedmas, sortedmasrav};
            return a;
        }
    }
}
