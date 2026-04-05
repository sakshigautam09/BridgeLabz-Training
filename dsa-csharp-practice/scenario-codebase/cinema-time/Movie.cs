public class Movie
{
    private string title;
    private string showTime;

    public Movie(string title, string showTime)
    {
        this.title = title;
        this.showTime = showTime;
    }

    public string GetTitle()
    {
        return title;
    } 
    public string GetShowTime() 
    {
        return showTime;
    }
}