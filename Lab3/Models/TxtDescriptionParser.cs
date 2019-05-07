using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Lab3.Models
{
    public class TxtDescriptionParser
    {
        public static string ReadDescriptionOfCity(string cityName)
        {
            var pathToFile = PathsToFolders.PathToCities + $"{cityName}.txt";

            var description = string.Empty;

            if(File.Exists(pathToFile))
            {
                description = File.ReadAllText(pathToFile);
            }
            
            return description;
        }
        
        public static string WriteDescriptionOfCityToFile(string cityName, string description)
        {
            var pathToFile = PathsToFolders.PathToCities + $"{cityName}.txt";
            File.WriteAllText(pathToFile, description);

            return pathToFile;
        }

    }
}