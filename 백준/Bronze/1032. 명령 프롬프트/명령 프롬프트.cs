internal class Program
{
    static void Main(string[] args)
    {
        int arr = int.Parse(Console.ReadLine());
        string[] str = new string[arr];
        string abc = "";
        for (int i = 0; i < arr; i++)
        {
            string s = "";
            str[i] = Console.ReadLine();
            if (i > 0)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (abc[j] != str[i][j])
                        s += "?";
                    else
                        s += str[i][j];
                }
                abc = s;
            }
            else
            {
                abc = str[0];
            }
        }
        Console.WriteLine(abc);
    }
}