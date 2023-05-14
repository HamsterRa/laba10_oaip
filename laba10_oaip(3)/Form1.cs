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
                Thread thread = new(() =>
                {
                    List<int> ints = sort.Sort(generateMassiv.GetList(), checkBox1.Checked, path);
                    sort.FillForm(labelChanges, labelRepits, labelTime);
                    new EnterListBox().EnterToListBox(ints);
                });
                thread.Start();
            }
            else
            {
                GenerateMassiv generateMassiv = new();
                SortClass sort = new(new SimpleSort());
                string path = "";
                if (checkBox1.Checked)
                {
                    FolderBrowserDialog folderBrowserDialog = new();
                    folderBrowserDialog.ShowDialog();
                    path = folderBrowserDialog.SelectedPath;
                }
                Thread thread = new(() =>
                {
                    List<int> ints = sort.Sort(generateMassiv.GetList(), checkBox1.Checked, path);
                    sort.FillForm(labelChanges, labelRepits, labelTime);
                    new EnterListBox().EnterToListBox(ints);
                });
                thread.Start();
            }
        }

        private void buttonForAnalyis_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            string[] st0 = { "Объём выборки", "Метод быстрой сортировки", "Метод выбора" };
            dataGridView1.Rows.Add(st0);
            for (int i = 1; i < 5; i++)
            {
                string[] st = { $"{Math.Pow(10, i)}", "", "" };
                GenerateMassiv generateMassiv = new();
                GenerateMassiv.lenght = Convert.ToInt32(Math.Pow(10, i));
                generateMassiv.Generate();
                SortClass sort = new(new SimpleSort());
                sort.Sort(generateMassiv.GetList(), false, "");
                st[2] = sort.ResultString();

                generateMassiv.Generate();
                SortClass fastsort = new(new FastSort());
                fastsort.Sort(generateMassiv.GetList(), false, "");
                st[1] = fastsort.ResultString();
                dataGridView1.Rows.Add(st);
            }
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