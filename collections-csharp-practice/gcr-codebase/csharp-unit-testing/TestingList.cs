using System;
using System.Collections.Generic;
using NUnit.Framework;

// --------------------- ListManager Class ---------------------
public class TestingList
{
    // Add an element to the list
    public void AddElement(List<int> list, int element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        list.Add(element);
    }

    // Remove an element from the list
    public bool RemoveElement(List<int> list, int element)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Remove(element); // returns true if element was removed, false if not found
    }

    // Get the size of the list
    public int GetSize(List<int> list)
    {
        if (list == null) throw new ArgumentNullException(nameof(list));
        return list.Count;
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class ListManagerTests
{
    private ListManager manager;
    private List<int> testList;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
        testList = new List<int>(); // start with empty list before each test
    }

    [Test]
    public void AddElement_AddsElementToList()
    {
        manager.AddElement(testList, 5);
        manager.AddElement(testList, 10);

        Assert.AreEqual(2, testList.Count);
        Assert.Contains(5, testList);
        Assert.Contains(10, testList);
    }

    [Test]
    public void RemoveElement_RemovesElementFromList()
    {
        testList.Add(5);
        testList.Add(10);

        bool removed = manager.RemoveElement(testList, 5);

        Assert.IsTrue(removed);
        Assert.AreEqual(1, testList.Count);
        Assert.IsFalse(testList.Contains(5));
    }

    [Test]
    public void RemoveElement_ElementNotInList_ReturnsFalse()
    {
        testList.Add(10);
        bool removed = manager.RemoveElement(testList, 5);

        Assert.IsFalse(removed);
        Assert.AreEqual(1, testList.Count); // list unchanged
    }

    [Test]
    public void GetSize_ReturnsCorrectListSize()
    {
        Assert.AreEqual(0, manager.GetSize(testList));

        testList.Add(1);
        testList.Add(2);

        Assert.AreEqual(2, manager.GetSize(testList));
    }

    [Test]
    public void Methods_ThrowException_OnNullList()
    {
        Assert.Throws<ArgumentNullException>(() => manager.AddElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => manager.RemoveElement(null, 5));
        Assert.Throws<ArgumentNullException>(() => manager.GetSize(null));
    }
}
