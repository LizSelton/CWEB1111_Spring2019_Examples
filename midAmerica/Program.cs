using System;
//C.FULTON

namespace midAmerica
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            int numberOfPassengers, zonesCrossed;
            double total;
            double [ , ] PASS_CHART = {
                                        { 7.50, 10.00, 12.00, 12.75},
                                        { 14.00, 18.50, 22.00, 23.00},
                                        { 20.00, 21.00, 32.00, 33.00},
                                        { 25.00, 27.50, 36.00, 37.00}
                                    };
            int EXIT = -1; //Sentinel Value

            //Housekeeping - Welcome the end-user and get primer
           numberOfPassengers =  getPrimer(); //Calling the method or Involking method

            //LOOPING structue that allows us to continously iterate
            while(numberOfPassengers != EXIT){


                //Defensively Program to ensure that a passenger between is a value between 1 and 4
                numberOfPassengers = checkPassenger(numberOfPassengers);


                //SEQUENCE - Get the number of zones crossed
                System.Console.WriteLine("Please enter the number of zones crossed");
                zonesCrossed = Convert.ToInt32(Console.ReadLine());


                //SEQUENCE Get Cost
                total  = PASS_CHART[numberOfPassengers-1, zonesCrossed];

                System.Console.WriteLine($"For {numberOfPassengers} passengers and {zonesCrossed} zones crossed, your ticket charge will be {total.ToString("c")}");


                //Get Primer
                System.Console.WriteLine($"To check another price, please enter the number of passengers or enter {EXIT} to exit the program");
                numberOfPassengers = Convert.ToInt32(Console.ReadLine());

                
            }

            //Notify the user that program has ended
            System.Console.WriteLine("End of Program");
        }//End of main


        //Defining the Module
        static int getPrimer(){
            int numberOfPassengers;
            System.Console.WriteLine("Welcome, this program will calculate the cost of your bus fare based on the number of passengers and zones entered");
            numberOfPassengers = Convert.ToInt32(Console.ReadLine());
            return numberOfPassengers;
        }

        static int checkPassenger(int pass){
                while(pass < 1 || pass > 4){
                    System.Console.WriteLine("Invalid entry, please enter a value thats between 1 and 4");
                    pass = Convert.ToInt32(Console.ReadLine());
                }
            return pass;
        }
    }
}
