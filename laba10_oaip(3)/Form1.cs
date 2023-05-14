using System;
using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;

namespace laba10_oaip_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        public List<int> mas;
        public string allstrings;
        public string Path;

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
        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }                 
            Path = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(Path, allstrings);

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            mas = new List<int>();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            Path = openFileDialog1.FileName;
            string text;
            
            using (StreamReader reader = new StreamReader(Path))
            {
                text = reader.ReadToEnd();
            }
            allstrings += text;
            MessageBox.Show(text);
            listBox1.Items.Add(text);
            foreach(string i in text.Split(' '))
            {
                mas.Add(Convert.ToInt32(i));
            }
        }
        private void buttonCreateMas_Click(object sender, EventArgs e)
        {
            mas = new List<int>();
            allstrings = "";
            listBox1.Items.Clear();
            
            string str = "";
            int random;
            Random rnd = new Random();
            for (int i = 0; i < trackBar1.Value; i++)
            {
                random = rnd.Next(-1000, 1000);
                mas.Add(random);
                str += random.ToString();
                str += " ";
            }
            listBox1.Items.Add(str);
            allstrings += str + "\n";
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonSimplSort.Checked)
            {
                SortClass simpleSort = new(new SimpleSort());
                mas = simpleSort.Sort(mas);
                foreach(string element in simpleSort.nado[0].Split('.'))
                {
                    listBox1.Items.Add(element);
                }
                
                labelPerestanovka.Text = simpleSort.perestanovka.ToString(); labelSravnenia.Text = simpleSort.sravnenia.ToString();
                TimeSpan ts = simpleSort.stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                labelTime.Text = elapsedTime;

                allstrings += simpleSort.nado[1];                               
            }
            else
            {
                SortClass fastSort = new(new FastSort());
                fastSort.stopwatch.Start();
                mas = fastSort.Sort(mas);
                fastSort.stopwatch.Stop();
                foreach (string element in fastSort.nado[0].Split('.'))
                {
                    listBox1.Items.Add(element);
                }

                labelPerestanovka.Text = fastSort.perestanovka.ToString(); labelSravnenia.Text = fastSort.sravnenia.ToString();
                TimeSpan ts = fastSort.stopwatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                labelTime.Text = elapsedTime;

                allstrings += fastSort.nado[1];
            }

        }
        public List<int> creation(int count)
        {
            List<int> arr = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int random = rnd.Next(-1000, 1000);
                arr.Add(random);

            }
            return arr;
        }
        private void buttonForAnalyis_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            string[] st0 = { "Объём выборки", "Метод быстрой сортировки", "Метод выбора" };
            dataGridView1.Rows.Add(st0);
            List<int> arr;
            TimeSpan ts;
            string elapsedTime; string elapsedTime1;
            //
            arr = creation(10);
            SortClass fastSort = new(new FastSort());
            fastSort.stopwatch.Start();
            arr = fastSort.Sort(arr);
            fastSort.stopwatch.Stop();
            ts = fastSort.stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            arr = creation(10);
            SortClass simpleSort = new(new SimpleSort());
            arr = simpleSort.Sort(arr);
            ts = simpleSort.stopwatch.Elapsed;
            elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            string[] st1 = { "10", $"{fastSort.perestanovka.ToString()} {fastSort.sravnenia.ToString()} {elapsedTime}", $"{simpleSort.perestanovka.ToString()} {simpleSort.sravnenia.ToString()} {elapsedTime1}" };
            dataGridView1.Rows.Add(st1);
            //
            arr = creation(50);
            fastSort = new(new FastSort());
            fastSort.stopwatch.Start();
            arr = fastSort.Sort(arr);
            fastSort.stopwatch.Stop();
            ts = fastSort.stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 50);
            arr = creation(50);
            simpleSort = new(new SimpleSort());
            arr = simpleSort.Sort(arr);
            ts = simpleSort.stopwatch.Elapsed;
            elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            string[] st2 = { "50", $"{fastSort.perestanovka.ToString()} {fastSort.sravnenia.ToString()} {elapsedTime}", $"{simpleSort.perestanovka.ToString()} {simpleSort.sravnenia.ToString()} {elapsedTime1}" };
            dataGridView1.Rows.Add(st2);
            //
            arr = creation(100);
            fastSort = new(new FastSort());
            fastSort.stopwatch.Start();
            arr = fastSort.Sort(arr);
            fastSort.stopwatch.Stop();
            ts = fastSort.stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 50);
            arr = creation(100);
            simpleSort = new(new SimpleSort());
            arr = simpleSort.Sort(arr);
            ts = simpleSort.stopwatch.Elapsed;
            elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            string[] st3 = { "100", $"{fastSort.perestanovka.ToString()} {fastSort.sravnenia.ToString()} {elapsedTime}", $"{simpleSort.perestanovka.ToString()} {simpleSort.sravnenia.ToString()} {elapsedTime1}" };
            dataGridView1.Rows.Add(st3);
            //
            arr = creation(200);
            fastSort = new(new FastSort());
            fastSort.stopwatch.Start();
            arr = fastSort.Sort(arr);
            fastSort.stopwatch.Stop();
            ts = fastSort.stopwatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 50);
            arr = creation(200);
            simpleSort = new(new SimpleSort());
            arr = simpleSort.Sort(arr);
            ts = simpleSort.stopwatch.Elapsed;
            elapsedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            string[] st4 = { "200", $"{fastSort.perestanovka.ToString()} {fastSort.sravnenia.ToString()} {elapsedTime}", $"{simpleSort.perestanovka.ToString()} {simpleSort.sravnenia.ToString()} {elapsedTime1}" };
            dataGridView1.Rows.Add(st4);
            //
        }
        // maybe useless

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBoxCountOfElements_TextChanged(object sender, EventArgs e)
            {
            int track;
            if (int.TryParse(textBoxCountOfElements.Text, out track) && track <= 10000)
            {
                trackBar1.Value = track;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxCountOfElements.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}