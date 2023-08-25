int arr = int.Parse(Console.ReadLine());
int area = 0;
int[,] pan = new int[100,100];
int x, y;
for(int i = 0; i < arr; i++)
{
    string[] str = Console.ReadLine().Split();
    x = int.Parse(str[0]);
    y = int.Parse(str[1]);
    for(int j = 0; j < 10; j++)
    {
        for(int z = 0; z < 10; z++)
        {
            pan[x + j, y + z] = 1;
        }
    }
}
for(int i = 0; i < pan.GetLength(0); i++)
{
    for(int j = 0; j< pan.GetLength(1); j++)
    {
        if(pan[i,j] == 1)
        {
            area++;
        }
    }
}
Console.WriteLine(area);