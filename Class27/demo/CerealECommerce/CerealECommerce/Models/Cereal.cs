using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Models
{
    public class Cereal : Product
    {
        public string Name { get; set; }
        public string Mfr { get; set; }
        public string Calories { get; set; }
        public string Protein { get; set; }
        public string Fat { get; set; }
        public string Sodium { get; set; }
        public string Fiber { get; set; }
        public string Carbo { get; set; }
        public string Sugars { get; set; }
        public string Potass { get; set; }
        public string Vitamins { get; set; }
        public string Shelf { get; set; }
        public string Weight { get; set; }
        public string Cups { get; set; }
        public string Rating { get; set; }
    }
}
