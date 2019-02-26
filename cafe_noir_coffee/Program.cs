using System;

namespace cafe_noir_coffee
{
    class Program
    {
        static void Main(string[] args)
        {
           //DECLARATIONS
           int zipCode, age, items, totalAge =0, itemsCount,coffeeZipCount= 0, noneCoffeeZipCount =0, thirtyCountItems = 0, underThirtyCountItems = 0, totalIterations = 0;
           double averageAge;
           int SENTINEL = 0, AGE_LOWER_LIMIT = 10, AGE_UPPER_LIMIT = 110, ITEM_LIMIT = 3, CUSTOMER_AGE_THRESHOLD = 30, 
           VALID_ZIP_UPPER = 9999, VALID_ZIP_LOWER = 1, ITEM_LOWER_LIMIT = 1,
            ITEM_UPPER_LIMIT = 12, COFFEE_SHOP_ZIP = 54984, orders=0;

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
                
                //Adding customer's age to accum total
                totalAge += age;




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
                orders +=1;
                //Clause if the items is less than the 1 and itemsCount == 3 than output "Error Message" 
                if(itemsCount >= ITEM_LIMIT && items < 0){
                    System.Console.WriteLine("Error Message");
                    items = 0;
                    orders -=1;
                }

                //Tally items fro those under thirty and those over thirty
                if(age > CUSTOMER_AGE_THRESHOLD){
                    thirtyCountItems += items;
                }else{
                    underThirtyCountItems += items;
                }

                //Display a count of the total number of items ordered from the coffee shop zip code, and a count of items that are not the coffee shop zip code
                if(zipCode == COFFEE_SHOP_ZIP){
                    coffeeZipCount += items;
                }else{
                    noneCoffeeZipCount +=items;
                }

                totalIterations +=1;
                System.Console.WriteLine($"ZipCode: {zipCode}\n Age {age} \n Number of Items Order: {items}");

                //Primer to reprompt end-user
                System.Console.WriteLine($"To enter another zipcode to rerun program or enter {SENTINEL} to exit program ");
                zipCode = Convert.ToInt32(Console.ReadLine());
                

            }

            //Get the average age
            averageAge = totalAge/totalIterations;

            //get count of customers that are under 30 and customers that are over 30
            System.Console.WriteLine($"Total items ordered at Coffee Zip code of {COFFEE_SHOP_ZIP}: {coffeeZipCount}\n Items not coffee zip code {noneCoffeeZipCount} \n Items ordered from customers 30 and over: {thirtyCountItems} \n Items order from customers under 30: {underThirtyCountItems} \n Averate age of all customers {averageAge} ");

        

        }
    }
}
