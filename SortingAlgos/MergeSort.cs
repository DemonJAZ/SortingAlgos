using System;
namespace SortingAlgos
{
	public static class MergeSort
	{
		public static void merge(int[] arr,int start,int mid,int end)
		{
			int[] left = new int[mid-start+1];
			int[] right = new int[end - mid];
			int x = start;
			int i=0;
			for(i = 0; i < left.Length; i++)
			{
				left[i] = arr[x];
				x++;
			}
			for (i = 0; i < right.Length; i++)
			{
				right[i] = arr[x];
				x++;
			}

			x = start;

			i = 0;
			int j = 0;

			while (i < left.Length && j<right.Length)
			{
				if (left[i] < right[j])
				{
					arr[x] = left[i];
					i++;
				}
				else
				{
					arr[x] = right[j];
					j++;
				}
				x++;
			}

			while (i < left.Length)
			{
				arr[x] = left[i];
				i++;
				x++;
			}

			while (j < right.Length)
			{
				arr[x] = right[j];
				j++;
				x++;
			}
 
		}

		public static void mergeSort(int[] arr, int start,int end)
		{
			if (start < end)
			{
				int mid = start + (end - start) / 2;
				mergeSort(arr, start, mid);
				mergeSort(arr, mid + 1, end);
				merge(arr, start, mid, end);
			}
		} 

		public static void sort(int[] arr)
		{
			mergeSort(arr, 0, arr.Length-1);
		}
	}
}

