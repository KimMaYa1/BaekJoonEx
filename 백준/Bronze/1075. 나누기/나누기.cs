internal class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int f = int.Parse(Console.ReadLine());

        int num = int.Parse(str.Substring(str.Length - 2, 2));

        int rest = int.Parse(str) % f;

        if(rest != 0)
        {
           if(num >= rest)
                num -= rest;
            else
                num += f - rest;
        }
        if (num >= f)
            num = num - f * (int)(num / f);
        if (num < 10)
            Console.WriteLine("0{0}", num);
        else
            Console.WriteLine(num);
    }
}