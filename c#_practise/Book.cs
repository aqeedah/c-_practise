using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practise
{
    internal class Book
    {
        public String title; //Attribute of classes
        public String author;
        public int pages;

        public Book(String aTitle, String aAuthor, int aPages) //Constructor = it has same name as class.
        {
            title = aTitle; 
            author = aAuthor;
            pages = aPages;
        }
    }
}
