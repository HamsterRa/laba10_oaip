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
        public List<int> Sort(List<int> ints, bool write, string path)
        {
            if (write) 
            {
                return SortMethod.SortWrite(ints,path); 
            }
            else
            {
                return SortMethod.Sort(ints);
            }
        }
        public void FillForm(Label changes, Label repits, Label times)
        {
            changes.Invoke((Action)(() => changes.Text = SortMethod.Changes().ToString()));
            repits.Invoke((Action)(() => repits.Text = SortMethod.Repits().ToString()));
            repits.Invoke((Action)(() => times.Text = SortMethod.Time().ToString()));  
        }
        public string ResultString()
        {
            return $"П: {SortMethod.Changes()} С: {SortMethod.Repits()} t: {SortMethod.Time()}";
        }

    }
}
