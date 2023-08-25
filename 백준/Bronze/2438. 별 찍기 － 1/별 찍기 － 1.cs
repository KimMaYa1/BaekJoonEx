int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    for(int j = 0; j < i; j++){
        Console.Write("*");
    }
    Console.WriteLine();
}