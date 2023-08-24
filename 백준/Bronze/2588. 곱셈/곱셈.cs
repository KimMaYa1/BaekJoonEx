int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int num = a * b;
Console.WriteLine(a * (b % 10));
b /= 10;
Console.WriteLine(a * (b % 10));
b /= 10;
Console.WriteLine(a * (b % 10));
Console.WriteLine(num);