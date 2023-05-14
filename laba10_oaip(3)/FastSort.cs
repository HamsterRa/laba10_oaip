using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_oaip_3_
{
    internal class FastSort :IMethodOfSort
    {
        private TimeSpan Times { get; set; }
        private long repits { get; set; } = 0;
        private long changes { get; set; } = 0;
        public List<int> Sort(List<int> mas)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            List<int> list = Reqursed(mas);
            sw.Stop();
            Times = sw.Elapsed;
            return list;
        }
        private List<int> Reqursed(List<int> mas)
        {
            if (mas.Count == 0 || mas.Count == 1) return mas;
            List<int> left = new();
            List<int> right = new();
            int index = new Random().Next(0, mas.Count - 1);
            for (int i = 0; i < mas.Count - 1; i++)
            {
                if (mas[i] < mas[^1]) left.Add(mas[i]);
                if (mas[i] > mas[^1]) right.Add(mas[i]);
                repits++;
            }

            changes++;
            left = Reqursed(left);
            right = Reqursed(right);
            List<int> final = new List<int>();
            foreach (int i in left) final.Add(i);
            final.Add(mas[^1]);
            foreach (int i in right) final.Add(i);
            return final;
        }
        private List<int> ReqursedString(List<int> mas, SaveToFile saveToFile)
        {
            if (mas.Count == 0 || mas.Count == 1) return mas;
            List<int> left = new();
            List<int> right = new();
            int index = new Random().Next(0, mas.Count - 1);
            for (int i = 0; i < mas.Count - 1; i++)
            {
                if (mas[i] < mas[^1]) left.Add(mas[i]);
                if (mas[i] > mas[^1]) right.Add(mas[i]);
                repits++;
            }
            saveToFile.Save(right,$"\nМассив правый");
            saveToFile.Save(right, $"\nМассив левый");
            changes++;
            left = ReqursedString(left, saveToFile);
            right = ReqursedString(right, saveToFile);
            List<int> final = new();
            foreach (int i in left) final.Add(i);
            final.Add(mas[^1]);
            foreach (int i in right) final.Add(i);
            return final;
        }
        public List<int> SortWrite(List<int> mas, string path)
        {
            Stopwatch sw = new();
            sw.Start();
            SaveToFile saveToFile = new(path, "Результаты сортировки");
            saveToFile.Save(mas, "Исходный массив");
            mas = ReqursedString(mas, saveToFile);
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
