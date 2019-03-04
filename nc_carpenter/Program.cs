using System;

namespace nc_carpenter
{
    class Program
    {
        static void Main(string[] args)
        {
           //DECLARATIONS
           int END = -1; //Sentinel
           string stringOrderNum, name, EMAIL_MESSAGE = "YOUR QOUTE HAS BEEN EMAILED";
           int orderNumber, numOfCharacters, woodType, colorType, CHARACTER_LIMIT = 6, OUTPUT_CHAR_MIN = 10, charOverage;
           double price, MINIMUM_CHARGE = 30.0, OAK_ADDITION = 15.0, GOLD_LEAF_ADDITION = 12.0, ADDITIONAL_CHAR = 3.0;

           System.Console.WriteLine("Welcome, this program is going to take in some data and calculate the cost of your sign based on your preferences");
           System.Console.WriteLine("Let's get started, please enter your order number: ");
           stringOrderNum = Console.ReadLine();
           orderNumber = Convert.ToInt32(stringOrderNum);  //Primer

            //Looping structure
           while(orderNumber != END){
               price = 0;
               
               //Gets the customers name -- sequence
               System.Console.WriteLine($"For {orderNumber} please enter a name for the order: ");
               name = Console.ReadLine();

                //Gets the the customers preferred wood type -- sequence
                System.Console.WriteLine($"{name} please enter your wood preference.  Enter 1 for 'Oak' and 2 for 'Pine': ");
                woodType = Convert.ToInt32(Console.ReadLine());

                //Get the number of characters the customer desire
                System.Console.WriteLine("Please enter the number of characters your sign will have.  6 characters are included within the minimum charge");
                numOfCharacters = Convert.ToInt32(Console.ReadLine());

                //Get the color of Characters the customer desire
                System.Console.WriteLine( "Last but not least, please enter your desired color for the characters.  Please enter 1 for Black and White Characters and 2 for Gold-Leaf");
                colorType = Convert.ToInt32(Console.ReadLine());

                //Assign price to the minimum charge -- Sequence
                price = price + MINIMUM_CHARGE;

                //Decide if additional charge is needed for customers who enter 1 for Oak -- Selection(Single Alternative)
                if(woodType == 1){
                    price = price + OAK_ADDITION;
                }

                //Logic to determine if additional charge is needed for character count over 6
                if(numOfCharacters >= CHARACTER_LIMIT){
                    //Determine how many letters they have over the included count of 6 -- Sequence
                    charOverage = numOfCharacters - CHARACTER_LIMIT;
                    price = price + (charOverage * ADDITIONAL_CHAR);
                }

                //Logic to determine additional cost if character color Type is Gold-Leaf - Selection(Single-Alternative)
                if(colorType == 2){

                    //Add an additional cost to the total
                    price = price + GOLD_LEAF_ADDITION;
                }


                //Output Information to end-user if certain conditions evaluate to true - Selection (dual-alternative)
                if(woodType == 1 && numOfCharacters >= OUTPUT_CHAR_MIN && colorType == 2){
                    System.Console.WriteLine($"{name} your total cost is {price.ToString("c")} for a wood type of Oak, character count of {numOfCharacters} and character color of 'Gold-Leaf'");
                }else{
                    System.Console.WriteLine( EMAIL_MESSAGE);
                }
                

                //Ask the primer again for continous iteration
                System.Console.WriteLine("To enter another order, please enter a new order number or enter -1 to exit the program: ");
                stringOrderNum = Console.ReadLine();
                orderNumber = Convert.ToInt32(stringOrderNum);  //Primer


           }
           
        //Ouput to notify the end-user that program has concluded
        System.Console.WriteLine( "Thanks for using my sign caluation app.  Don't forget to sign-up for our newsletter");
        }
    }
}
