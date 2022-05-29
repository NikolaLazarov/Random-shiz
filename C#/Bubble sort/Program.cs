int mid;
int p = 0;
Random rnd = new Random();
int[] arrNums = new int[7];
Console.WriteLine("The original array: ");
for (int i = 0; i < arrNums.Length; i++)
{
    arrNums[i] = rnd.Next(1, 9);
    Console.Write(arrNums[i] + " ");
}
Console.WriteLine();
for (int k = 0; k < arrNums.Length; k++)
{
    for (int i = 0; i < arrNums.Length - 1; i++)
    {
        if (arrNums[i] > arrNums[i + 1])
        {
            mid = arrNums[i];
            arrNums[i] = arrNums[i + 1];
            arrNums[i + 1] = mid;
            p++;
        }
    }
    if (p == 0)
    {
        break;
    }
}
Console.WriteLine("\nThe array sorted via Bubble sort:");
for (int i = 0; i < arrNums.Length; i++)
{
    Console.Write(arrNums[i] + " ");
}