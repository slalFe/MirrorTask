using System.IO;

namespace MirrorTask.Queries
{
    public class FileQueries
    {
        public string[] ReadLinesFromFile(string fileStorageDirectory, string fileToRead)
        {
            return File.ReadAllLines(fileStorageDirectory + fileToRead);
        }
    }
}
