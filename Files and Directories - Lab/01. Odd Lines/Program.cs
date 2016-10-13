using System.IO;
using System.Linq;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");
            //for (int i = 1; i < text.Length; i+=2)
            //{
            //    File.AppendAllText("output.txt", text[i] +
            //        Environment.NewLine);
            //}
            File.WriteAllLines("output.txt",
                text.Where((line, index) => index % 2 == 1));
        }
    }
}
