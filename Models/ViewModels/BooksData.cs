using System.Collections.Generic;
using Culda_Andrada_Lab2.Models;

namespace Culda_Andrada_Lab2.Models.ViewModels
{
    public class BooksData
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
