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
        private TimeSpan Times { get; set; }
        private long repits { get; set; } = 0;
        private long changes { get; set; } = 0;
        public List<int> Sort(List<int> mas)
        {
            Stopwatch sw = new();
            sw.Start();
            int lastMember = mas.Count - 1;
            while (lastMember > 0)
            {
                for (int i = 0; i < lastMember; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        (mas[i], mas[i + 1]) = (mas[i + 1], mas[i]);
                        changes++;
                    }
                    repits++;
                }
                lastMember--;
            }
            sw.Stop();
            Times = sw.Elapsed;
            return mas;
        }
        public List<int> SortWrite(List<int> mas, string path)
        {
            Stopwatch sw = new();
            sw.Start();
            int lastMember = mas.Count - 1;
            SaveToFile saveToFile = new(path, "Результаты сортировки");
            saveToFile.Save(mas, "Исходный массив");
            while (lastMember > 0)
            {
                for (int i = 0; i < lastMember; i++)
                {
                    if (mas[i] > mas[i + 1])
                    {
                        saveToFile.Save($"Иттерация {repits} сравнили {mas[i]} и {mas[i + 1]} смена местами");
                        (mas[i], mas[i + 1]) = (mas[i + 1], mas[i]);
                        changes++;
                    }
                    else
                    {
                        saveToFile.Save($"Иттерация {repits} сравнили {mas[i]} и {mas[i + 1]} осталось все как есть");
                    }
                    repits++;
                }
                lastMember--;
            }
            sw.Stop();
            Times = sw.Elapsed;
            saveToFile.Save($"Количество сравнений {repits} \nКоличество перемещений {changes} \nЗатраченное время {Times}");
            saveToFile.Save(mas, "Финальный массив");
            MessageBox.Show("Запись в файл законченна");
            return mas;
        }
        public TimeSpan Time() 
        {
            return Times;
        }
        public long Repits()
        {
            return repits;
        }
        public long Changes()
        {
              return changes;
        }
        
    }
}
