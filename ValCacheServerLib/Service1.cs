using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace ValCacheServerLib
{
    public class FileServerService : IFileServer
    {
        public const string FILESERVE_DIR = @".\files";

        public string[] GetAvailableFiles()
        {
            DirectoryInfo d = new DirectoryInfo(FILESERVE_DIR);
            FileInfo[] files = d.GetFiles("*.*");

            // Extract filename from file info
            string[] availableFiles = new string[files.Length];
            for (int i = 0; i < files.Length; ++i)
            {
                availableFiles[i] = files[i].Name;
            }

            return availableFiles;
        }

        public Stream GetFile(string filename)
        {
            string filePath = Path.Combine(FILESERVE_DIR, filename);
            try
            {
                var file = File.OpenRead(filePath);
                return file;
            }
            catch (IOException ex)
            {
                Console.WriteLine(String.Format("An exception was thrown while trying to open file {0}", filePath));
                Console.WriteLine("Exception is: ");
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
