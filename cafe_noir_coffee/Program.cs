using System;

namespace cafe_noir_coffee
{
    class Program
    {
        static void Main(string[] args)
        {
           //DECLARATIONS
           int zipCode, age, items, totalAge, itemsCount;
           double averageAge;
           int SENTINEL = 0, AGE_LOWER_LIMIT = 10, AGE_UPPER_LIMIT = 110, ITEM_LIMIT = 3, 
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

                //Ask the end-user for age
                System.Console.WriteLine($"Please enter age - your age must be between {AGE_LOWER_LIMIT} and {AGE_UPPER_LIMIT}");
                age = Convert.ToInt32(Console.ReadLine());

                //Defensive Progamming to check for valid age
                while(age < AGE_LOWER_LIMIT ||age > AGE_UPPER_LIMIT ){
                    System.Console.WriteLine( $"Invalid age, please enter an age that is greater than {AGE_LOWER_LIMIT} and less than {AGE_UPPER_LIMIT}");
                    age = Convert.ToInt32(Console.ReadLine());
                }

                //Ask for the number of items
                System.Console.WriteLine("Please enter the number of items");
                items = Convert.ToInt32(Console.ReadLine());

                /** Defensively Program to enforce that the clerk enters at least 1 item and no more than 12 items.!The clerk will only have two more attempts after the first entry
                **/
                itemsCount = 0;
                while((items < ITEM_LOWER_LIMIT || items > ITEM_UPPER_LIMIT) && itemsCount < ITEM_LIMIT){
                    System.Console.WriteLine( $"Invalid items, please enter an items that is greater than {ITEM_LOWER_LIMIT} and less than {ITEM_UPPER_LIMIT}");
                    items = Convert.ToInt32(Console.ReadLine());
                    itemsCount +=1;
                    Console.WriteLine(itemsCount);
                }

                //Clause if the items is less than the 1 and itemsCount == 3 than output "Error Message" 
                if(itemsCount >= ITEM_LIMIT && items < 0){
                    System.Console.WriteLine("Error Message");
                }


                //Primer to reprompt end-user
                System.Console.WriteLine($"To enter another zipcode to rerun program or enter {SENTINEL} to exit program ");
                zipCode = Convert.ToInt32(Console.ReadLine());
                

            }


        

        }
    }
}
