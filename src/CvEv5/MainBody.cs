using System;
using System.Collections.Generic;
using System.Linq;

namespace CvEv5
{
    class MainBody
    {
        string title;
        string domains;
        string yearsOfExperience;
        private DomainsAndTypes domainsAndTypes;
        Random random;
        public MainBody()
        {
            random = new Random();
            domainsAndTypes = DomainsAndTypes.getInstance();
        }

        private void getDomainText(string domain)
        {
            string[] docs = domainsAndTypes.getDomainDocs(domain);
            var fulltext = domain;
            for (int i = 0; i < docs.Length; i++)
            {
                var randomNumber = random.Next(docs.Length);
                if (docs[randomNumber] != null)
                {
                    string randomDoc = docs[randomNumber];
                    docs[randomNumber] = null;
                }
            }
        }
        
    }
}