using System.Formats.Asn1;

namespace laba10_oaip_3_
{
    public class GenerateMassiv
    {
        public static int lenght { get; set; }
        public static List<List<int>> HistoryList { get; set; }
        private static List<int>? lastList { get; set; }
        public void Generate(ListBox ListBox)
        {
            HistoryList ??= new();
            if(lastList != null) HistoryList.Add(lastList);
            lastList = new();
            string str = "";
            int random;
            Random rnd = new();
            for (int i = 0; i < lenght; i++)
            {
                EnterListBox enterListBox = new ();
                random = rnd.Next(-10000, 10000);
                lastList.Add(random);
                str += random.ToString() + " ";
                if ((i + 1) % 24 == 0)
                {
                    enterListBox.EnterToListBox(str);
                    str = "";
                }
                if (i + 1 == lenght)
                {
                    enterListBox.EnterToListBox(str);
                    str = "";
                }
            }
            MessageBox.Show("Массив создан");
        }
        public List<int> GetList() => lastList ?? new List<int>();
        public void SetList(List<int> newints)
        {
            HistoryList ??= new();
            if (lastList != null) HistoryList.Add(lastList);
            lastList = newints;
        }

        public void Generate()
        {
            HistoryList ??= new();
            if (lastList != null) HistoryList.Add(lastList);
            lastList = new();
            Random rnd = new();
            for (int i = 0; i < lenght; i++) lastList.Add(rnd.Next(-10000, 10000));
        }
        public void SetZero()
        {
            HistoryList ??= new();
            if (lastList != null) HistoryList.Add(lastList);
            lastList = new();
        }
    }
}
