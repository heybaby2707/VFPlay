using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VFLauncher.Utilities
{
    public class EmoticonRender
    {
        private List<KeyValuePair<string, string>> _dictionary = new List<KeyValuePair<string, string>>() 
        {
            new KeyValuePair<string, string>(":-)", "a.png"),
            new KeyValuePair<string, string>(";-(", "a.png"),
        };

        public string Parse(string text)
        {
            foreach (KeyValuePair<string, string> kvp in _dictionary)
            {
                text = text.Replace(kvp.Key, @"C:\Users\Buddiez\Documents\Visual Studio 2010\Projects\abc\abc\a.png");
            }
            return text;
        }
    }
}
