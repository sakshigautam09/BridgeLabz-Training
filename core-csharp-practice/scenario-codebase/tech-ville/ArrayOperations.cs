// ======================================
// UC-3: Array operations
// Sorting, Searching, Copying
// ======================================

public class ArrayOperations
{
    // Bubble Sort
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
}
