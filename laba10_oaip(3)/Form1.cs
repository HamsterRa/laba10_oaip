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
            EnterListBox.textBox = listBox1;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            GenerateMassiv generate = new();
            if (generate.GetList().Count == 0)
            {
                MessageBox.Show("Нельзя сохранить пустой массив");
                return;
            }
            FolderBrowserDialog folder = new();
            folder.ShowDialog();
            SaveToFile saveToFile = new(folder.SelectedPath);
            saveToFile.Save("Массив чисел", generate.GetList());
        }

        private async void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.ShowDialog();
            using (StreamReader reader = new(openFileDialog.FileName))
            {
                EnterListBox enterListBox = new();
                List<int> ints = new();
                foreach (string i in (await reader.ReadToEndAsync()).Split(' '))
                {
                    int result;
                    if (int.TryParse(i, out result))
                    {
                        ints.Add(result);
                    }
                }
                GenerateMassiv generateMassiv = new();
                generateMassiv.SetList(ints);
                string str = "";
                EnterListBox.Clear();
                new EnterListBox().EnterToListBox(ints);
            }
        }

        private void buttonCreateMas_Click(object sender, EventArgs e)
        {
            int lenght = trackBar1.Value;
            listBox1.Items.Clear();
            GenerateMassiv.lenght = lenght;
            Thread threadgenerate = new(() => { new GenerateMassiv().Generate(listBox1); });
            threadgenerate.Start();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (radioButtonFastSort.Checked)
            {
                GenerateMassiv generateMassiv = new();
                SortClass sort = new(new FastSort());
                string path = "";
                if (checkBox1.Checked)
                {
                    FolderBrowserDialog folderBrowserDialog = new();
                    folderBrowserDialog.ShowDialog();
                    path = folderBrowserDialog.SelectedPath;
                }
                List<int> ints = sort.Sort(generateMassiv.GetList(), checkBox1.Checked, path);
                sort.FillForm(labelChanges, labelRepits, labelTime);
                new EnterListBox().EnterToListBox(ints);
            }
            else
            {
                GenerateMassiv generateMassiv = new();
                SortClass sort = new(new SimpleSort());
                string path = "";
                if(checkBox1.Checked)
                {
                    FolderBrowserDialog folderBrowserDialog = new();
                    folderBrowserDialog.ShowDialog();
                    path = folderBrowserDialog.SelectedPath;
                }
                Thread thread = new(() =>
                {
                    List<int> ints = sort.Sort(generateMassiv.GetList(),checkBox1.Checked,path);
                    sort.FillForm(labelChanges, labelRepits, labelTime);
                    new EnterListBox().EnterToListBox(ints);
                });
                thread.Start();
            }
        }

        private void buttonForAnalyis_Click(object sender, EventArgs e)
        {
            /*
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
            */
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}