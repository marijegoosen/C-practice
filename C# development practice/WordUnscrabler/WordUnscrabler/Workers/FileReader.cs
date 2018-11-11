using System;
using System.IO;

namespace WordUnscrabler.Workers
{
    class FileReader
    {
        public string[] Read(string fileName)
        {
            string[] fileContent;

            try
            {
               fileContent = File.ReadAllLines(fileName);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return fileContent;
        }
    }
}
