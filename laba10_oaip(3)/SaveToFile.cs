using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace laba10_oaip_3_
{
    public class SaveToFile
    {
        public string Path { get; set; }
        private bool repit = false;
        public SaveToFile(string path)
        {
            Path = path;
        }
        public SaveToFile(string path, string name)
        {
            Path = path +"/" + name + ".txt";
        }
        public async void Save(string Name, string answer)
        {
            Path += "/" + Name + ".txt";
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteLineAsync(answer);
            }
            repit = true;
        }
        public async void Save(string Name, List<int> ints) 
        {
            Path += "/" + Name + ".txt";
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteAsync("\n");
                foreach (int i in ints)
                {
                    await writer.WriteAsync(i + " ");
                }
            }
            repit = true;
        }
        public async void Save(string Name, List<int> ints, string answer)
        {
            Path += "/" + Name + ".txt";
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteLineAsync(answer);
                foreach (int i in ints)
                {
                    await writer.WriteAsync(i+" ");
                }
            }
            repit = true;
        }
        public async void Save(string answer)
        {
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteLineAsync(answer);
            }
            repit = true;
        }
        public async void Save(List<int> ints)
        {
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteAsync("\n");
                foreach (int i in ints)
                {
                    await writer.WriteAsync(i + " ");
                }
            }
            repit = true;
        }
        public async void Save(List<int> ints, string answer)
        {
            using (StreamWriter writer = new StreamWriter(Path, repit))
            {
                await writer.WriteLineAsync(answer);
                foreach (int i in ints)
                {
                    await writer.WriteAsync(i + " ");
                }
            }
            repit = true;
        }
    }
}
