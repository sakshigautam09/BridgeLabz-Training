using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipedStreams
{
    static void Main()
    {
        try
        {
            // Create pipe (one-way: Writer → Reader)
            AnonymousPipeServerStream server = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

            AnonymousPipeClientStream client = new AnonymousPipeClientStream(PipeDirection.In, server.GetClientHandleAsString());

            Thread writerThread = new Thread(() => WriteData(server));
            Thread readerThread = new Thread(() => ReadData(client));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }

    static void WriteData(AnonymousPipeServerStream pipe)
    {
        try
        {
            StreamWriter writer = new StreamWriter(pipe);
            writer.AutoFlush = true;

            writer.WriteLine("Hello from Writer Thread");
            writer.WriteLine("This is inter-thread communication");
            writer.WriteLine("END");

            writer.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }
    }

    static void ReadData(AnonymousPipeClientStream pipe)
    {
        try
        {
            StreamReader reader = new StreamReader(pipe);

            string line;
            while ((line = reader.ReadLine()) != "END")
            {
                Console.WriteLine("Reader received: " + line);
            }

            reader.Close();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}
