Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));

int num = Convert.ToInt32(Console.ReadLine());

for(int i=0;i<num;i++)
{
    Console.Write("*");
    for(int j=0;j<i;j++)
    {    
        Console.Write("*");
    }
    Console.WriteLine();
}


Console.Out.Flush();