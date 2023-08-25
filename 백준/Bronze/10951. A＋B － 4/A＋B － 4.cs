while(true)
{
    string str = Console.ReadLine();
    if(str == null)
        break;
    string[] strs = str.Split();
    int a = Convert.ToInt32(strs[0]) + Convert.ToInt32(strs[1]);
    Console.WriteLine("{0}",a);
}