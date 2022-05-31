using static System.Console;
public class Program
{
    public static void quickSort(int[] array, int start, int end)
    {
        if (end <= start) return;
        int pivot = partition(array, start, end);
        quickSort(array, start, pivot - 1);
        quickSort(array, pivot + 1, end);
    }
    public static int partition(int[] array, int start, int end)
    {
        int temp;
        int pivot = array[end];
        int i = start - 1;
        for (int j = start; j <= end - 1; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        i++;
        temp = array[i];
        array[i] = array[end];
        array[end] = temp;

        return i;
    }
    public static void Main(string[] args)
    {
        int[] array = { 6, 3, 5, 2, 1, 7, 9, 8, 4};
        quickSort(array, 0, array.Length - 1);
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }        
        Console.WriteLine();
    }
}