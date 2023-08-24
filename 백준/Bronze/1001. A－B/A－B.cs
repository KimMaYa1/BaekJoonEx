internal class Program
{
    static void Main(string[] args)
    {
        string[] sa = Console.ReadLine().Split();

        int a = int.Parse(sa[0]) - int.Parse(sa[1]);
        Console.WriteLine(a);
    }
}