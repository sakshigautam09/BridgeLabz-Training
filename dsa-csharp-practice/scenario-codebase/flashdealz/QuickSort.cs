public class QuickSort
{
    private Product[] products;

    public QuickSort(Product[] products)
    {
        this.products = products;
    }

    public void SortByDiscountDescending()
    {
        QuickSortFunc(0, products.Length - 1);
    }

    private void QuickSortFunc(int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(low, high);
            QuickSortFunc(low, pivotIndex - 1);
            QuickSortFunc(pivotIndex + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        int pivot = products[high].Discount;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (products[j].Discount > pivot) // higher discount first
            {
                i++;
                Swap(i, j);
            }
        }

        Swap(i + 1, high);
        return i + 1;
    }

    private void Swap(int i, int j)
    {
        Product temp = products[i];
        products[i] = products[j];
        products[j] = temp;
    }

    public void Display()
    {
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine(
                "Product ID: " + products[i].ProductId +
                ", Discount: " + products[i].Discount + "%"
            );
        }
    }
}
