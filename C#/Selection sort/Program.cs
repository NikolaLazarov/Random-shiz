using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(10);
            Write(" " + array[i]);
        }
        WriteLine();
        Selection_Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Write(" " + array[i]);
        }
        WriteLine();

        /*selection sort*/
        void Selection_Sort(int[] array)
        {
            //fist int that runs the length of the array - 1 because of j = i + 1
            for (int i = 0; i < array.Length - 1; i++)
            {
                //creating the min var which holds the index of i
                int min = i;
                //in the second for loop we find the index of the lowest element in the array
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }
                //here we swap the places of element of index i and the element of index min
                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }


        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}