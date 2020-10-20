using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateLoadRepFile
{
    public class RepSearcher
    {
        //private string _openPath;
        //private string _savePath;
        //private readonly string repExtension = "*.rep";

        public static void GetAllFiles(string rootDirectory, string fileExtension, List<string> files)
        {
            string[] directories = Directory.GetDirectories(rootDirectory);
            files.AddRange(Directory.GetFiles(rootDirectory, fileExtension));

            foreach (string path in directories)
            {
                GetAllFiles(path, fileExtension, files);
            }
        }

        public static void AddDirectoriesFiles(List<string> files,string fileExtension, List<string> directories)
        {            
            foreach (string path in directories)
            {
                files.AddRange(Directory.GetFiles(path, fileExtension));
            }
        }
    }
}
