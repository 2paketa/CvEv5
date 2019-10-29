using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CvEv5
{
    public class DomainsAndTypes
    {

        private DomainsAndTypes()
        {
        }

        private static DomainsAndTypes Instance = null;

        public static DomainsAndTypes getInstance()
        {
            if (Instance == null)
            {
                Instance = new DomainsAndTypes();
            }
            return Instance;
        }

        public string[] getDocs(string domain)
        {
            var sourcePath = @"C:\Users\m.prekas\CvEv5\Data\Library.csv";
            StreamReader sr = new StreamReader(sourcePath);
            string[] docs = null;
            using (sr)
            {
                while(sr.ReadLine() != domain)
                {
                    sr.ReadLine();
                }
                docs = sr.ReadLine().ToString().Split(", ");
            }
            return docs;
        }
    }
}