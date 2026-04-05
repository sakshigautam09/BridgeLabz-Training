class Browser
{
    private Tab currentTab;
    private TabStack closedTabs = new TabStack();

    public void OpenTab(string homepage)
    {
        currentTab = new Tab(homepage);
    }

    public void CloseTab()
    {
        closedTabs.Push(currentTab);
        currentTab = null;
        Console.WriteLine("Tab closed");
    }

    public void RestoreTab()
    {
        currentTab = closedTabs.Pop();
        Console.WriteLine("Tab restored: " + currentTab.GetCurrentPage());
    }

    public Tab GetTab()
    {
        return currentTab;
    }
}
