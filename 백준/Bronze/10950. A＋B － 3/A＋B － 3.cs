int num = int.Parse(Console.ReadLine());

for(int i = 0; i < num; i++)
{
    string[] strs = Console.ReadLine().Split();
    Console.WriteLine(int.Parse(strs[0]) + int.Parse(strs[1]));
}