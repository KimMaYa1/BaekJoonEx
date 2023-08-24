internal class Program
{
    static void Main(string[] args)
    {
        int arr = int.Parse(Console.ReadLine());
        for(int i = 0; i < arr; i++)
        {
            int num = 1;
            string[] str = Console.ReadLine().Split();
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            for(int j = 0; j < b; j++)
            {
                if(a % 10 != 0)
                    num = (num * a ) % 10;
                else 
                    num = 10;
            }
            Console.WriteLine(num);
        }
    }
}