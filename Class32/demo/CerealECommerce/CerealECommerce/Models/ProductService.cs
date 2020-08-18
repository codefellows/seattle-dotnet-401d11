using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Models
{
    public class ProductService : IProduct
    {


        // Get product        
        public List<Product> GetProducts()
        {
            // Header: name,mfr,type,calories,protein,fat,sodium,fiber,carbo,sugars,potass,vitamins,shelf,weight,cups,rating

            List<Product> products = new List<Product>();
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\cereal.csv"));
            string[] myFile = File.ReadAllLines(newPath);
            // make a dictionary of the differen manufactureres and have the lookup change out the text

            for (int i = 1; i < myFile.Length; i++)
            {
                string[] fields = myFile[i].Split(',');
                products.Add(new Cereal
                {
                    Name = fields[0],
                    Mfr = fields[1],
                    Calories = fields[2],
                    Protein = fields[3],
                    Fat = fields[4],
                    Sodium = fields[5],
                    Fiber = fields[6],
                    Carbo = fields[7],
                    Sugars = fields[8],
                    Potass = fields[9],
                    Vitamins = fields[10],
                    Shelf = fields[11],
                    Weight = fields[12],
                    Cups = fields[13],
                    Rating = fields[14]
                });
            }

            return products;
        }

    }
}
