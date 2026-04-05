class CustomDictionary
{
    private GenreNode[] data;
    private int count;

    public CustomDictionary(int size)
    {
        data = new GenreNode[size];
        count = 0;
    }

    public GenreNode Get(string genre)
    {
        for (int i = 0; i < count; i++)
        {
            if (data[i].Genre == genre)
                return data[i];
        }
        return null;
    }

    public GenreNode Add(string genre)
    {
        GenreNode node = new GenreNode(genre);
        data[count++] = node;
        return node;
    }

    public GenreNode[] GetAll()
    {
        return data;
    }

    public int Count { get { return count; }}
}
