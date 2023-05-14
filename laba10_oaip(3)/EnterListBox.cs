namespace laba10_oaip_3_
{
    public class EnterListBox
    {
        public static ListBox textBox;
        public EnterListBox(ListBox list)
        {
            textBox = list;
        }
        public EnterListBox()
        {
           // textBox.Invoke((Action)(() => textBox.Items.Clear()));
        }
        public void EnterToListBox(string text)
        {
            textBox.Invoke((Action)(() => textBox.Items.Add(text)));
        }
        public void EnterToListBox(List<int> ints)
        {
            EnterListBox enterListBox = new();
            string str = "";
            EnterListBox.Clear();
            Thread thread = new(() =>
            {
                for (int i = 0; i < ints.Count; i++)
                {
                    str += ints[i] + " ";
                    if ((i + 1) % 23 == 0)
                    {
                        enterListBox.EnterToListBox(str);
                        str = "";
                    }
                    if (i + 1 == ints.Count)
                    {
                        enterListBox.EnterToListBox(str);
                        str = "";
                    }
                }
            });
            thread.Start();
        }
        public static void Clear()
        {
            textBox.Invoke((Action)(() => textBox.Items.Clear()));
        }
    }
}
