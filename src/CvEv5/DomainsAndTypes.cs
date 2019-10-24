using System;
using System.Collections.Generic;
using System.Linq;

namespace CvEv5
{
    public class DomainsAndTypes
    {
        static string[] legal = {"Contract", "Bylaws", "Regulations"};
        static string[] medical = {"SPCs", "PILs", "Clinical trials"};
        static string[] marketing = {"Brochures", "campaigns"};

        static Dictionary<string, string[]> docsDict;

        private DomainsAndTypes()
        {
            docsDict = new Dictionary<string, string[]>
            {
                {"legal", legal },
                {"medical", medical},
                {"marketing", marketing}
            };
        }

        public string[] getDomainDocs(string domain)
        {
            return docsDict[domain];
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
    }
}