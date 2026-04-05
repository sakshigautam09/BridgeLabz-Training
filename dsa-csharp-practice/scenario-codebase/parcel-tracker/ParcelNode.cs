public class ParcelNode
{
    public string StageName { get; set; }
    public ParcelNode Next { get; set; }

    public ParcelNode(string stageName)
    {
        this.StageName = stageName;
        this.Next = null;
    }
}
