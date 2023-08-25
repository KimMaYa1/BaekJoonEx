int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.Write("*");
    for(int j = 0; j < i; j++){
        Console.Write("*");
    }
    Console.WriteLine();
}