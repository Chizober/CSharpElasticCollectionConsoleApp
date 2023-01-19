using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;


namespace ElasticCollectionsFilter
{
    internal class FilterProducts
    {


        public void ListProducts(string[] properties = null)
        {

            List<Product> products = new List<Product>(){
             new Product(){ Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 6000 },
             new Product(){ Id = 2, Name = "Vintage", Quantity = 400, Price = 280, Category = "Chairs", OrderCount = 4000 },
             new Product(){ Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
             };
            Console.WriteLine("\n\t------------  List of  Selected Products------------\n");


            foreach (Product product in products)
            {

                dynamic productData = new ExpandoObject();

                productData.Id = product.Id;
                productData.Name = product.Name;

                productData.Quantity = product.Quantity;
                productData.Price = product.Price;

                productData.Category = product.Category;
                productData.OrderCount = product.OrderCount;


                foreach (string property in properties)
                {


                    switch (property)
                    {
                        

                        case "id":
                            Console.Write($"\t\tId: {productData.Id}");
                            break;

                        case "name":
                            Console.Write($"\tName: {productData.Name}");
                            break;

                        case "quantity":
                            Console.Write($"\tQuantity: {productData.Quantity}");
                            break;

                        case "price":
                            Console.Write($"\tPrice: {productData.Price}");
                            break;

                        case "category":
                            Console.Write($"\tCategory: {productData.Category}");
                            break;

                        case "ordercount":
                            Console.Write($"\tOrderCount: {productData.OrderCount}");
                            break;
                        case "":
                            Console.WriteLine($"\tId: {productData.Id} \t Name: {productData.Name}\t Quantity: {productData.Quantity} \tPrice: {productData.Price} \tCategory: {productData.Category} \tOrderCount: {productData.OrderCount}");
                            break;

                        default:
                            Console.Clear();

                            Console.WriteLine("\n  Invalid Properties entered,try again!");
                            
                            Filter();
                            break;
                    }


                }

                Console.WriteLine("\n");


            }
        }

        
        public string Filter()
        {

           
            Console.Write("\n Enter properties(id or name or price or quantity or category or ordercount,Use comma if more than one): \n\n  ");

            string userInput = Console.ReadLine().ToLower().Replace(" ", "");

            return userInput;
        }
        
    }
}


