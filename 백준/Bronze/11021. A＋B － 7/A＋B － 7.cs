int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= num; i++)
{
    string[] str = Console.ReadLine().Split();
    Console.WriteLine("Case #{0}: {1}", i, (int.Parse(str[0]) + int.Parse(str[1])));
}