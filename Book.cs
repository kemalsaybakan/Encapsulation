using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Book
    {
        // Class variables
        private int pageNumber;
        private String bookName, author;
        
        // Constructor Method
        public Book(String bookName, int pageNumber, String author)
        {
            this.bookName = bookName;
            this.pageNumber = pageNumber;
            this.author = author;

            if (pageNumber < 1)
            {
                this.pageNumber = 1;
            }
            else
            {
                this.pageNumber = pageNumber;
            }
        }

        // Getter and Setter Methods
        public int getPageNumber()
        {
            return this.pageNumber;
        }

        public void setPageNumber(int pageNumber)
        {
            if (pageNumber < 1)
            {
                this.pageNumber = 1;
            }
            else
            {
                this.pageNumber = pageNumber;
            }
        }
    }

}
