using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_oaip_3_
{
    class SortClass
    {
        public int sravnenia, perestanovka;
        public Stopwatch stopwatch = new Stopwatch();
        public string[] nado;
        public IMethodOfSort SortMethod { private get; set; }
        public SortClass(IMethodOfSort sortMethod)
        {
            SortMethod = sortMethod;
        }
        public List<int> Sort(List<int> mas)
        {
            mas = SortMethod.Sort(mas);
            sravnenia = SortMethod.GetSrPere()[0];
            perestanovka = SortMethod.GetSrPere()[1];
            stopwatch = SortMethod.GetTime();
            nado = SortMethod.GetConsole();
            return mas;
        }

    }
}
