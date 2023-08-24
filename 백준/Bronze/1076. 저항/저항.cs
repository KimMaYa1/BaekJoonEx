internal class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        double a = 0;
        for(int i = 0; i < 3; i++)
        {
            string str = Console.ReadLine();
            int num = 0;
            switch(str)
            {
                case "black":
                    num = 0;
                    break;
                case "brown":
                    num = 1;
                    break;
                case "red":
                    num = 2;
                    break;
                case "orange":
                    num = 3;
                    break;
                case "yellow":
                    num = 4;
                    break;
                case "green":
                    num = 5;
                    break;
                case "blue":
                    num = 6;
                    break;
                case "violet":
                    num = 7;
                    break;
                case "grey":
                    num = 8;
                    break;
                case "white":
                    num = 9;
                    break;
            }
            if(i == 0)
                a = num *10;
            else if(i == 1)
                a += num;
            else
                for(int j = 0; j < num; j++)
                    a *= 10;
        }
        Console.WriteLine(a);
    }
}