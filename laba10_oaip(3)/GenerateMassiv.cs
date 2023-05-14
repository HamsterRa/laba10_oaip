namespace laba10_oaip_3_
{
    public class GenerateMassiv
    {
        public static int lenght;
        private static List<int>? lastList;
        public GenerateMassiv()
        {
            lastList = new List<int>();
        }
        public void Generate(ListBox ListBox)
        {
            lastList = new();
            string str = "";
            int random;
            Random rnd = new();
            for (int i = 0; i < lenght; i++)
            {
                random = rnd.Next(-10000, 10000);
                lastList.Add(random);
                str += random.ToString() + " ";
                if ((i + 1) % 24 == 0)
                {
                    ListBox.Invoke((Action)(() => ListBox.Items.Add(str)));
                    str = "";
                }
                if (i + 1 == lenght)
                {
                    ListBox.Invoke((Action)(() => ListBox.Items.Add(str)));
                    str = "";
                }
            }
        }
        public List<int> GetList() => lastList ?? new List<int>();
        public void Generate()
        {
            lastList = new();
            Random rnd = new();
            for (int i = 0; i < lenght; i++) lastList.Add(rnd.Next(-10000, 10000));
        }
    }
}
