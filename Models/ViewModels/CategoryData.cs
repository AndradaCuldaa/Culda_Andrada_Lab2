using Culda_Andrada_Lab2.Models;
using System.Collections.Generic;

namespace Culda_Andrada_Lab2.Models.ViewModels
{
    public class CategoryData
    {
        public IEnumerable<Category> Categories { get; set; } = new List<Category>();
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
        public int CategoryID { get; set; }
    }
}
