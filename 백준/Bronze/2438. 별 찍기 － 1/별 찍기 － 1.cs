int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    for(int j = num-i; j < num; j++){
        Console.Write("*");
    }
    Console.WriteLine();
}