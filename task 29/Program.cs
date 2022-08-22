void PrintArray(int[,] arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j =0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}");
            if(j<arr.GetLength(1)-1)
            {
                Console.Write(",");
            }
        }
    Console.WriteLine("]");
    }
}
void FillArray(int[,] arr)
{
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j =0; j<arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,100);
        }
    Console.WriteLine();
    }
}

int[,]array = new int[1, 8];
FillArray(array);
PrintArray(array);