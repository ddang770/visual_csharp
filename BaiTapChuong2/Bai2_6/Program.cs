// See https://aka.ms/new-console-template for more information

string s; int n = 0;
Console.Write("Nhap do dai array (> 0): ");
s = Console.ReadLine();
while (!int.TryParse(s, out n) || n < 1)
{
    Console.Write("Nhap lai do dai array: ");
    s = Console.ReadLine();
}

int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"arr[{i}]: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Array.Sort(arr);
Console.WriteLine("max: " + arr[n-1]);
Console.WriteLine("min: " + arr[0]);
Console.WriteLine("Phan tu lon thu 2: " + arr[n-2]);  // Bai 2_7
