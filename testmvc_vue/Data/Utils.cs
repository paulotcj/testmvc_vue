using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Extensions.Configuration;



namespace testmvc_vue.Data
{
    public abstract class Utils
    {
        public Utils()
        {


        }

        public static string GetTranslation(string translationKey)
        {
            try {
                Dictionary<string, string> dicTranslations = new Dictionary<string, string>();

                dicTranslations.Add("welcome", "Welcome");
                dicTranslations.Add("follow_pattern", "Follow this pattern when adding components: ");
                dicTranslations.Add("component_list", "Components list:");
                dicTranslations.Add("lorem_ipsum1", "Lorem Ipsum 1");
                dicTranslations.Add("lorem_ipsum2", "Lorem Ipsum 2");
                dicTranslations.Add("lorem_ipsum3", "Lorem Ipsum 3");
                dicTranslations.Add("lorem_ipsum4", "Lorem Ipsum 4");
                dicTranslations.Add("lorem_ipsum5", "Lorem Ipsum 5");

                return dicTranslations[translationKey];
            }
            catch (Exception e) {
                return "";
            }


        }
    }
}
