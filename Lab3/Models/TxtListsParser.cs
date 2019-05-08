using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Lab3.Models
{
    public class TxtListsParser
    {
        public static IEnumerable<string> GetListFormFiles(string filename)
        {
            var pathToFile = PathsToFolders.PathToArticles + $"{filename}.txt";

            var listOfItems = new List<string>(); 

            if(File.Exists(pathToFile))
            {                   
                using (StreamReader file = new StreamReader(pathToFile))
                {
                    var line = string.Empty;

                    while ((line = file.ReadLine())!=null)
                    {
                        listOfItems.Add(line);
                    }
                }
            }

            return listOfItems;
        }
    }
}