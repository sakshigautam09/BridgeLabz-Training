using System;
using System.IO;
using NUnit.Framework;

// --------------------- FileProcessor Class ---------------------
public class TestingFileHandling
{
    // Write content to a file
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    // Read content from a file
    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            throw new IOException("File does not exist.");
        }

        return File.ReadAllText(filename);
    }
}

// --------------------- NUnit Tests ---------------------
[TestFixture]
public class FileProcessorTests
{
    private FileProcessor processor;
    private string testFile = "testfile.txt";

    [SetUp]
    public void Setup()
    {
        processor = new FileProcessor();

        // Ensure no leftover file from previous tests
        if (File.Exists(testFile))
        {
            File.Delete(testFile);
        }
    }

    [TearDown]
    public void Teardown()
    {
        // Clean up the file after each test
        if (File.Exists(testFile))
        {
            File.Delete(testFile);
        }
    }

    [Test]
    public void WriteToFile_CreatesFileAndWritesContent()
    {
        string content = "Hello, world!";
        processor.WriteToFile(testFile, content);

        Assert.IsTrue(File.Exists(testFile));                 // File exists
        Assert.AreEqual(content, File.ReadAllText(testFile)); // Content is correct
    }

    [Test]
    public void ReadFromFile_FileExists_ReturnsContent()
    {
        string content = "Test content";
        File.WriteAllText(testFile, content);

        string result = processor.ReadFromFile(testFile);
        Assert.AreEqual(content, result);
    }

    [Test]
    public void ReadFromFile_FileDoesNotExist_ThrowsIOException()
    {
        Assert.Throws<IOException>(() => processor.ReadFromFile("nonexistentfile.txt"));
    }
}
