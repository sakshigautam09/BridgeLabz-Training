using System.Collections.Generic;

interface IFileReader
{
    List<Match> Read(string path);
}
