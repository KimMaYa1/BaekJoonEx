using System;
using System.ComponentModel;
using System.Text;

namespace BaekJoonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            StringBuilder bulider = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                string[] str = Console.ReadLine().Split();
                bulider.Append(int.Parse(str[0]) + int.Parse(str[1]) + "\n");
            }
            Console.WriteLine(bulider.ToString());
        }
    }
}