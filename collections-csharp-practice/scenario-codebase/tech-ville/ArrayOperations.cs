// ======================================
// UC-3: Array operations
// Sorting, Searching, Copying
// ======================================

public class ArrayOperations
{
    // Bubble Sort (Ascending)
    public void SortIds(int[] ids)
    {
        for (int i = 0; i < ids.Length - 1; i++)
        {
            for (int j = 0; j < ids.Length - i - 1; j++)
            {
                if (ids[j] > ids[j + 1])
                {
                    int temp = ids[j];
                    ids[j] = ids[j + 1];
                    ids[j + 1] = temp;
                }
            }
        }
    }

    // Linear Search
    public bool SearchId(int[] ids, int target)
    {
        foreach (int id in ids)
        {
            if (id == target)
                return true;
        }
        return false;
    }

    // Copy Array
    public int[] CopyArray(int[] original)
    {
        int[] copy = new int[original.Length];

        for (int i = 0; i < original.Length; i++)
        {
            copy[i] = original[i];
        }

        return copy;
    }


    // ================= UC-3 ADDITIONS =================

    // Descending Sort
    public void SortIdsDescending(int[] ids)
    {
        for (int i = 0; i < ids.Length - 1; i++)
        {
            for (int j = 0; j < ids.Length - i - 1; j++)
            {
                if (ids[j] < ids[j + 1])
                {
                    int temp = ids[j];
                    ids[j] = ids[j + 1];
                    ids[j + 1] = temp;
                }
            }
        }
    }

    // Binary Search (array must be sorted)
    public bool BinarySearch(int[] ids, int target)
    {
        int left = 0;
        int right = ids.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (ids[mid] == target)
                return true;

            if (ids[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }

    // Safe display helper
    public void DisplayArray(int[] ids)
    {
        if (ids == null || ids.Length == 0)
        {
            System.Console.WriteLine("Array empty.");
            return;
        }

        foreach (int id in ids)
            System.Console.Write(id + " ");
    }
}
