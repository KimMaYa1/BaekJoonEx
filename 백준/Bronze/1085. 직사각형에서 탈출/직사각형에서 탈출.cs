string[] str = Console.ReadLine().Split();

int x, y, w, h;
int min;
x = int.Parse(str[0]);
y = int.Parse(str[1]);
w = int.Parse(str[2]);
h = int.Parse(str[3]);

min = Math.Min(Math.Min(x,w - x),Math.Min(y, h -y));

Console.WriteLine(min);