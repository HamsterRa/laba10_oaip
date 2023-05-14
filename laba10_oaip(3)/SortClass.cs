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
        public IMethodOfSort SortMethod { get; set; }
        public SortClass(IMethodOfSort sortMethod)
        {
            SortMethod = sortMethod;
        }

    }
}
