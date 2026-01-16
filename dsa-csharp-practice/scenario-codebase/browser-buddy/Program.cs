class Program
{
    static void Main()
    {
        Browser browser = new Browser();
        string url = Console.ReadLine();
        browser.OpenTab(url);
        Tab tab = browser.GetTab();

        tab.Visit("github.com");
        tab.Visit("leetcode.com");

        tab.Back();
        tab.Forward();

        browser.CloseTab();
        browser.RestoreTab();
    }
}
