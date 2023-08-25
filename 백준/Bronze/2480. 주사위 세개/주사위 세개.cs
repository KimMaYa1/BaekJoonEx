string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);
int num = 0;
if (a == b && a == c)
{
    num = 10000 + a * 1000;
}
else if (a == b || a == c)
    num = 1000 + a * 100;
else if (b == c)
    num = 1000 + b * 100;
else
    num = Math.Max(a, Math.Max(b, c)) * 100;
Console.WriteLine(num);