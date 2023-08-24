internal class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split();
        
        int x , y, w, h;
        int min1 = 0, min2 = 0;
        x = int.Parse(str[0]);
        y = int.Parse(str[1]);
        w = int.Parse(str[2]);
        h = int.Parse(str[3]);
        if(x > w - x)
            min1 = w - x;
        else
            min1 = x;
        if(y > h - y)
            min2 = h - y;
        else
            min2 = y;
        if(min1 > min2)
            Console.WriteLine(min2);
        else
            Console.WriteLine(min1);
    }
}