using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Concenstration { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int Views { get; set; }
    }
}
