using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCATS.Models
{
    public class Cat
    {
        public int CatId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
    }
}