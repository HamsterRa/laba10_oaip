using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10_oaip_3_
{
    interface IMethodOfSort
    {
        List<int> Sort(List<int> mas);
        List<int> SortWrite(List<int> mas,string path);
        TimeSpan Time();
        long Repits();
        long Changes();
    }
}
