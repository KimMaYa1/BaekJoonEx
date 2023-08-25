string[] str = Console.ReadLine().Split();
int h = int.Parse(str[0]);
int m = int.Parse(str[1]);
m += int.Parse(Console.ReadLine());

while(m > 59)
{
    m -= 60;
    h += 1;
    if(h > 23)
        h -= 24;
}
Console.WriteLine($"{h} {m}");