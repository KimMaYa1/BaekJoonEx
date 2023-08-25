int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int num = 0;
if(x > 0)
{
    if(y > 0)
        num = 1;
    else
        num = 4;
}
else
{
    if(y > 0)
        num = 2;
    else
        num = 3;
}
Console.WriteLine(num);