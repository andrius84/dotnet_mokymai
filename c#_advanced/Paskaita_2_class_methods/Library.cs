using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_2_class_methods
{
    public class Library
    {
        public List<string> Books { get; set; } = new List<string>();
        public void AddBook(string Book)
        {
            Books.Add(Book);
        }
        public void RemoveBook(string Book)
        {
            Books.Remove(Book);
        }
    }
}
