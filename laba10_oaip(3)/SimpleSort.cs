using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_oaip_3_
{
    internal class SimpleSort : IMethodOfSort
    {
        public string Sortedmas = "", sortedmasrav; public int srav=0, pere = 0; public Stopwatch stopwatch = new Stopwatch();
        public List<int> Sort(List<int> mas)
        {
            
            stopwatch.Start();
            for (int i=0; i < mas.Count-1; i++)
            {
                int min = i;
                for(int j=i+1; j < mas.Count; j++)
                {
                    if (mas[j] < mas[min]) { min = j; }
                    sortedmasrav += $"{mas[j]} & {mas[i]} сравниваются\n";
                    srav++;
                }
                int for_change = mas[min];
                mas[min] = mas[i];
                mas[i] = for_change;
                pere++;
                Sortedmas += $".{i}-ая итерация, перестановка чисел {mas[min]} и {mas[i]}.\nСостояние массива: ";
                sortedmasrav += $".{i}-ая итерация, перестановка чисел {mas[min]} и {mas[i]}.\nСостояние массива: ";
                for (int e=0; e <mas.Count; e++)
                {
                    Sortedmas += mas[e].ToString();
                    Sortedmas += " ";

                    sortedmasrav += mas[e].ToString() + " ";

                }
                Sortedmas += "\n";
                sortedmasrav += "\n";
            }
            stopwatch.Stop();
            return mas;
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
            string[] a = { Sortedmas, sortedmasrav };
            return a;
        }

        public void QuickSort(List<int> mas, int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
