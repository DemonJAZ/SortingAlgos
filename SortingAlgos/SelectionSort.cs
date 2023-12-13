using System;
namespace SortingAlgos
{
	public static class SelectionSort
	{
		public static void sort(int[] arr)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				int minIndex = i;
				for(int j = i; j < arr.Length; j++)
				{
					if (arr[minIndex] >arr[j])
					{
						minIndex = j;
					}
				}
				Swap.swap(arr, i, minIndex);
			}
		}
	}
}

