using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_C_Sharp_Lesson_2
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DisplayText => $"{Name} - {Price:C}";

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
