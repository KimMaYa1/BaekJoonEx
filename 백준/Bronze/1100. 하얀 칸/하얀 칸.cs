int num = 0;
for(int i = 0; i < 8; i++)
{
    int a = i % 2;
    string str = Console.ReadLine();
    for(int j = 0; j< 8; j++)
    {
        int b = j % 2;
        if(a == 0 && b == 0 && str[j] == 'F')
            num++;
        else if(a == 1 && b == 1 && str[j] == 'F')
            num++;
    }
}
Console.WriteLine(num);