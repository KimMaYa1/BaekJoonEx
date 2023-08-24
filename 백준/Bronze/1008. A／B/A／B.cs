internal class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        double c = double.Parse(str[0]) / double.Parse(str[1]);
        Console.WriteLine(c);
    }
}