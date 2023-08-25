string[] str = Console.ReadLine().Split();
int h = int.Parse(str[0]);
int m = int.Parse(str[1]);
m -= 45;
if(m < 0)
{
    h -= 1;
    m += 60;
    if(h < 0)
        h += 24;
}
Console.WriteLine($"{h} {m}");