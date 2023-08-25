long price = long.Parse(Console.ReadLine());
int num = int.Parse(Console.ReadLine());
long sum = 0;
string str = "No";
for(int i = 0; i < num; i++){
    string[] str1 = Console.ReadLine().Split();
    sum += int.Parse(str1[0]) * int.Parse(str1[1]);
}
if(price == sum)
    str = "Yes";
Console.WriteLine(str);