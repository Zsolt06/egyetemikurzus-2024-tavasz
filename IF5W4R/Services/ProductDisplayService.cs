﻿using IF5W4R.Models;

namespace IF5W4R.Services
{
    public class ProductDisplayService : IProductDisplayService
    {
        public void DisplayProducts(List<Product> products)
        {
            Console.WriteLine("Current products: ");
            DisplayTableHeader();
            foreach (var product in products)
            {
                DisplayProductRow(product);
            }
        }

        private void DisplayTableHeader()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("| ID |              Name              |    Category    | Quantity |      Price      |");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }

        private void DisplayProductRow(Product product)
        {
            string formattedID = string.Format("{0,3}", product.ID);
            string formattedName = FormatString(product.Name, 30);
            string formattedCategory = FormatString(product.Category, 14);
            string formattedQuantity = string.Format("{0,8}", product.Quantity);
            string formattedPrice = string.Format("{0,15:C}", product.Price);

            Console.WriteLine($"| {formattedID} | {formattedName} | {formattedCategory} | {formattedQuantity} | {formattedPrice} |");
        }

        private string FormatString(string input, int width)
        {
            return input.PadRight(width).Substring(0, width);
        }
    }
}
