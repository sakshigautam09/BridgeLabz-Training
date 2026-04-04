using System;
using NUnit.Framework;

// --------------------- PerformanceTester Class ---------------------
public class PerformanceTesting
{
    // Simulate a long-running task (busy-wait for ~3 seconds)
    public string LongRunningTask()
    {
        DateTime start = DateTime.Now;
        // Busy-wait loop for ~3 seconds
        while ((DateTime.Now - start).TotalMilliseconds < 3000)
        {
            // Do nothing, just wait
        }
        return "Task Completed";
    }
}

// --------------------- NUnit Test ---------------------
[TestFixture]
public class PerformanceTesterTests
{
    private PerformanceTester tester;

    [SetUp]
    public void Setup()
    {
        tester = new PerformanceTester();
    }

    [Test]
    [Timeout(2000)] // Fail if method takes more than 2 seconds
    public void LongRunningTask_ShouldTimeout()
    {
        tester.LongRunningTask();
    }
}
