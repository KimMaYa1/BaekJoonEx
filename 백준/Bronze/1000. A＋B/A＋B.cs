namespace BaekJoonProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ss = Console.ReadLine();
            string[] sa = ss.Split();

            int a = int.Parse(sa[0]);
            int b = int.Parse(sa[1]);

            Console.WriteLine(a + b);
        }
    }
}