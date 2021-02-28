using System;
using System.IO;

namespace ClassLibraryCore
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException(fileName);

            return File.Exists(fileName);
        }
    }
}
