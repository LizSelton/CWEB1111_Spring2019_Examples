using System;

namespace cafe_noir_coffee
{
    class Program
    {
        static void Main(string[] args)
        {
           //DECLARATIONS
           int zipCode, age, items, totalAge, count;
           double averageAge;
           int SENTINEL = 0, AGE_LOWER_LIMIT = 10, AGE_UPPER_LIMIT = 110, 
           VALID_ZIP_UPPER = 9999, VALID_ZIP_LOWER = 1, ITEM_LOWER_LIMIT = 1,
            ITEM_UPPER_LIMIT = 12, COFFEE_SHOP_ZIP = 54984;

            System.Console.WriteLine("Hello, this application will take data and output data");
            System.Console.WriteLine( "Let's get started, please enter your zipcode");
            zipCode = Convert.ToInt32(Console.ReadLine());

            //Continous Iteration that allows the end-user to re-run the program until Sentinel value is entered
            while(zipCode != SENTINEL){
              

                //Defensive Progamming to check to make sure the zipcode is more than 5 characters
                while(zipCode < VALID_ZIP_UPPER ||zipCode < VALID_ZIP_LOWER ){
                    System.Console.WriteLine( "Invalid zipcode, please enter a zipcode that is greater than 5 digits");
                    zipCode = Convert.ToInt32(Console.ReadLine());
                }
            }


        

        }
    }
}
