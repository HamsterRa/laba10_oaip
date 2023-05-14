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
        public static void Clear()
        {
            textBox.Invoke((Action)(() => textBox.Items.Clear()));
        }
    }
}
