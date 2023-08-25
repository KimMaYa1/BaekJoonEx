int yun = int.Parse(Console.ReadLine());
int num = 0;
if(yun % 400 == 0)
    num = 1;
else if(yun % 100 == 0)
    num = 0;
else if(yun % 4 == 0)
    num = 1;
Console.WriteLine(num);
