using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public struct Class1
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int NumberOfPages { get; set; }

        public Class1(string title, string author, string publisher, int numberOfPages)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            NumberOfPages = numberOfPages;
        }
    }
}
