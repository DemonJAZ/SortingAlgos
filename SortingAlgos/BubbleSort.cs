using System;
namespace SortingAlgos
{
	public static class BubbleSort
	{
		public static void sort(int[] arr)
		{
			for(int i = arr.Length-1; i>=0; i--)
			{
				int swapcount = 0;
				for(int j = 0; j < i; j++)
				{
					if (arr[j] > arr[j + 1])
					{
						swapcount++;
						Swap.swap(arr, j, j + 1);
					}
				}
				if (swapcount == 0)
				{
					return;
				}
			}
		}
	}
}

