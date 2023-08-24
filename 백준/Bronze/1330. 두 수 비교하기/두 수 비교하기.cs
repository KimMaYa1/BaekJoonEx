string[] str = Console.ReadLine().Split();
if(int.Parse(str[0])>int.Parse(str[1]))
    Console.WriteLine(">");
else if(int.Parse(str[0]) < int.Parse(str[1]))
    Console.WriteLine("<");
else
    Console.WriteLine("==");