using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Models
{
    public interface IProduct
    {
        List<Product> GetProducts();
    }
}
