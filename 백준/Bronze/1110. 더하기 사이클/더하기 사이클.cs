int a = int.Parse(Console.ReadLine());
int b;
int c = a;
int i = 0;
int num = 0;
while (a != num)
{
    b = ((c / 10) + (c % 10)) % 10;
    num = (c % 10 * 10) + b;
    c = num;
    i++;
}
if (i == 0)
    i = 1;
Console.WriteLine(i);