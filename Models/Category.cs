using System.Collections.Generic;

namespace Assignment1_COMP2139.Models;

public class Category
{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    
}