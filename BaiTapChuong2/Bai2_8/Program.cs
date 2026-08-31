// See https://aka.ms/new-console-template for more information

int n = 3;
int[,] matrix1 =
{
    {1,2,3 },
    {4,5,6 },
    {7,8,9 }
};
int[,] matrix2 =
{
    {1,2,3 },
    {1,2,3 },
    {1,2,3 }
};

for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write((matrix1[i, j] + matrix2[i,j]) + " ");
    }
    Console.Write("\n");
}