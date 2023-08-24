internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        string[] str = Console.ReadLine().Split();
        
        int min = int.Parse(str[0]);
        int max = 0;
        if(num == 1)
            Console.WriteLine(int.Parse(str[0]) * int.Parse(str[0]));
        else
        {
            for(int i = 0; i < num; i++)
            {
                int a = int.Parse(str[i]);
                if(a < min)
                    min = a;
                if(a > max)
                    max = a;
            }
            Console.WriteLine(min * max);
        }
    }
}