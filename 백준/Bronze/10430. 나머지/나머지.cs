string[] str = Console.ReadLine().Split();
int a = int.Parse(str[0]), b = int.Parse(str[1]), c = int.Parse(str[2]);
Console.WriteLine((a+b)%c);
Console.WriteLine(((a%c)+(b%c)) % c);
Console.WriteLine((a*b)%c);
Console.WriteLine(((a%c)*(b%c)) % c);