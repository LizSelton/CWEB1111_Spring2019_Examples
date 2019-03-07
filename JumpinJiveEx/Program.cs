using System;

namespace JumpinJiveEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLRATIONS
            string[] PRODUCT = {"Whipped Cream", "Cinnamon","Chocolate Sauce","Amaretto", "Irish Whiskey" };

            double [] PRICE = {.89, .25, .59, 1.50, 1.75};

            string selectedProduct;
            double accumPrice;

            string EXIT = "EXIT";
            bool isFound;


            System.Console.WriteLine("Welcome, please select for the product list below");
            for(var x = 0; x < PRODUCT.Length; x++){
                System.Console.WriteLine($"Enter  {PRODUCT[x]} for a cost of {PRICE[x].ToString("c")}.");
            }
            System.Console.WriteLine("Please enter a number below:");
            selectedProduct = Console.ReadLine();
        }
    }
}
