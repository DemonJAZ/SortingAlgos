using System;
namespace SortingAlgos
{
	public class QuickSort
	{

		private static int partitionLast(int[] arr,int left,int right)
		{
			int pivot = arr[right];
			int pIndex = left;
			for(int i = left; i < right; i++)
			{
				if (arr[i] <= pivot)
				{
					Swap.swap(arr, i, pIndex);
					pIndex++;
				}
			}
			Swap.swap(arr, pIndex, right);
			return pIndex;
		}

		private static int partitionFirst(int[] arr, int left,int right)
		{
			int pivot = arr[left];
			int pIndex = right;
			for(int i=right;i> left; i--)
			{
				if (arr[i] > pivot)
				{
					Swap.swap(arr, i, pIndex);
					pIndex--;
				}
			}
			Swap.swap(arr, pIndex, left);
			return pIndex;
		}

		private static int partitionRandom(int[] arr,int left,int right)
		{
			int randIndex = QuickSort.randomIndex(left, right);
			Swap.swap(arr, right, randIndex);
            int pivot = arr[right];
            int pIndex = left;
            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    Swap.swap(arr, i, pIndex);
                    pIndex++;
                }
            }
            Swap.swap(arr, pIndex, right);
            return pIndex;
        }

		private static int randomIndex(int left,int right)
		{
			Random random = new Random();
			return random.Next(left, right+1);
		}

		public static void quickSort(int[] arr,int left,int right)
		{
			if (left < right)
			{
				int pIndex = partitionRandom(arr, left, right);
				quickSort(arr, left, pIndex - 1);
				quickSort(arr, pIndex + 1, right);
			}
		}

		public static void sort(int[] arr)
		{
			quickSort(arr, 0, arr.Length - 1);
		}
	}
}

