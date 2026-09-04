// See https://aka.ms/new-console-template for more information

var d = new Dictionary<char, int>();
Console.Write("Nhap string: ");
string s = Console.ReadLine();
foreach(char c in s) {
    if (c == ' ') continue;
    if (d.ContainsKey(c))
    {
        d[c] ++;
    }
    else
    {
        d[c] = 1;
    }
}
foreach(var i in d)
{
    Console.WriteLine(i.Key + ": " + i.Value);
}

int max_value = 0;
char max_key = ' ';
foreach (var i in d)
{
    if (max_value < i.Value) {
        max_value = i.Value;
        max_key = i.Key;
    }
}

Console.Write("Cac ky tu xuat hien nhieu nhat la: ");
foreach (var i in d)
{
    if (max_value == i.Value)
    {
        Console.Write(i.Key + " ");
    }
}