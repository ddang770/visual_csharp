
string correctUsername = "admin";
string correctPassword = "123";
int attempts = 0;
int maxAttempts = 3;
bool isAuthenticated = false;
while (attempts<maxAttempts)
{
    Console.WriteLine($"Lan thu {attempts+1}/{maxAttempts}");
    Console.Write("Nhap username: ");
    string username = Console.ReadLine();
    Console.Write("Nhap password: ");
    string password = Console.ReadLine();
    if (username == correctUsername && password == correctPassword)
    {
        isAuthenticated = true;
        break;
    }
    attempts++;
    int remaining = maxAttempts - attempts;

    if (remaining > 0)
    {
        Console.WriteLine($"Thong tin ko chinh xac, ban con {remaining} lan thu");
    }
}

// Kết quả sau khi rời vòng lặp
if (isAuthenticated)
{
    Console.WriteLine("Dang nhap thanh cong!");
}
else
{
    Console.WriteLine("Ban da nhap sai qua 3 lan. Dong chuong trinh!");
}