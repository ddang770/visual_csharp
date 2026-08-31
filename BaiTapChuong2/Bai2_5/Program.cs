// See https://aka.ms/new-console-template for more information

string s; int n=0;
Console.Write("Nhap do dai array (> 0): ");
s = Console.ReadLine();
while(!int.TryParse(s, out n) || n<1)
{
    Console.Write("Nhap lai do dai array: ");
    s = Console.ReadLine();
}

string[] arr = new string[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"arr[{i}]: ");
    arr[i]= Console.ReadLine();
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine(arr[i]);
}