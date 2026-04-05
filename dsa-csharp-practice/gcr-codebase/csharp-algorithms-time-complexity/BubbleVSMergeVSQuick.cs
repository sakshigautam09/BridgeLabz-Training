using System;
using System.Diagnostics;
class BubbleVSMergeVSQuick
{
    static void Main()
    {
        int n = 10000;  
        int[] data1 = new int[n];
        int[] data2 = new int[n];
        int[] data3 = new int[n];

        for (int i = 0; i < n; i++)
        {
            data1[i] = n - i;
            data2[i] = n - i;
            data3[i] = n - i;
        }

        Stopwatch sw = new Stopwatch();
        // -------- Bubble Sort --------
        sw.Start();
        BubbleSort(data1);
        sw.Stop();
        Console.WriteLine("Bubble Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");

        // -------- Merge Sort --------
        sw.Restart();
        MergeSort(data2, 0, data2.Length - 1);
        sw.Stop();
        Console.WriteLine("Merge Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");

        // -------- Quick Sort --------
        sw.Restart();
        QuickSort(data3, 0, data3.Length - 1);
        sw.Stop();
        Console.WriteLine("Quick Sort Time: " + sw.Elapsed.TotalMilliseconds + " ms");
    }

    // ---------------- Bubble Sort ----------------
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // ---------------- Merge Sort ----------------
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int i1 = 0, j1 = 0, k = left;

        while (i1 < n1 && j1 < n2)
        {
            if (L[i1] <= R[j1])
                arr[k++] = L[i1++];
            else
                arr[k++] = R[j1++];
        }

        while (i1 < n1)
            arr[k++] = L[i1++];

        while (j1 < n2)
            arr[k++] = R[j1++];
    }

    // ---------------- Quick Sort ----------------
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);

            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }
}
