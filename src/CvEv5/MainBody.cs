using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CvECommon;

namespace CvEv5
{
    public class MainBody
    {
        string title;
        string domains;
        string yearsOfExperience;
        private DomainsAndTypes domainsAndTypes;
        Random rng;
        public MainBody()
        {
            domainsAndTypes = DomainsAndTypes.getInstance();
            rng = new Random();
        }
        
        public string getDomainText(string domain)
        {
            var fulltext = domain;
            var randomDocs = domainsAndTypes.getDocs(domain);
            rng.Shuffle(randomDocs);
            for (int i = 0; i < randomDocs.Length; i++)
            {
                if (i == 0)
                    fulltext += $"({randomDocs[i]}";
                else 
                    fulltext += $", {randomDocs[i]}";
            }
            fulltext += ")";
            return fulltext;
        }
        

        public string getDomains(string[] domains)
        {
            string finalText = "";
            for (int i = 0; i < domains.Length; i++)
            {
                if (i == 0)
                {
                     finalText += getDomainText(domains[i]);
                }
                else
                {
                    finalText += $",  {getDomainText(domains[i])}";
                }
            }
            
            return finalText;
        }



    }
}