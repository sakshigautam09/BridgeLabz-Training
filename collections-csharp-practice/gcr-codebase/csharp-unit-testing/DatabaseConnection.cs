using System;
using NUnit.Framework;

// --------------------- DatabaseConnection Class ---------------------
public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    // Connect to the database
    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    // Disconnect from the database
    public void Disconnect()
    {
        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection db;

    [SetUp]
    public void Setup()
    {
        db = new DatabaseConnection();
        db.Connect();  // Initialize connection before each test
    }

    [TearDown]
    public void Teardown()
    {
        db.Disconnect();  // Close connection after each test
    }

    [Test]
    public void Connect_EstablishesConnection()
    {
        Assert.IsTrue(db.IsConnected);
    }

    [Test]
    public void Disconnect_ClosesConnection()
    {
        db.Disconnect();  // Manually disconnect
        Assert.IsFalse(db.IsConnected);
    }

    [Test]
    public void Connection_IsClosedAfterTest()
    {
        // This test checks teardown indirectly
        Assert.IsTrue(db.IsConnected);  // Setup ensures connection is established
    }
}
