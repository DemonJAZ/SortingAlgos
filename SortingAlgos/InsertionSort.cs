using System;
namespace SortingAlgos
{
	public static class InsertionSort
	{
		public static void sort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int key = arr[i];
				int j = i-1;
				for (; j>=0 && arr[j]>key; j--)
				{
					arr[j + 1] = arr[j];
				}
				arr[j+1] = key;
			}
		}
	}
}

