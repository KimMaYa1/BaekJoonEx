int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    String[] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);
    Console.WriteLine("Case #{0}: {1} + {2} = {3}", i, a, b, a+b);
}