using SortingAlgos;

internal class Program
{
    public static void printArr(int[] arr)
    {
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 23, 45, 6, 7, 3 };

        SelectionSort.sort(arr);
        Console.WriteLine("Selection Sort");
        printArr(arr);
        Console.WriteLine();

        int[] arr2 = { 556, 1, 23, 45, 5, 6, 77, 5, 43, 3, 45 };

        BubbleSort.sort(arr2);
        Console.WriteLine("Bubble Sort");
        printArr(arr2);
        Console.WriteLine();
        int[] arr3 = { 556, 1, 23, 45, 5, 6, 77, 5, 43, 3, 45 };

        InsertionSort.sort(arr3);
        Console.WriteLine("Insertion Sort");
        printArr(arr3);


        Console.WriteLine();
        int[] arr4 = { 556, 1, 23, 45, 5, 6, 77, 5, 43, 3, 45 };

        MergeSort.sort(arr4);
        Console.WriteLine("Merge Sort");
        printArr(arr4);


        Console.WriteLine();
        int[] arr5 = { 556, 1, 23, 45, 5, 6, 77, 5, 43, 3, 45 };

        QuickSort.sort(arr5);
        Console.WriteLine("Quick Sort");
        printArr(arr5);
    }
}