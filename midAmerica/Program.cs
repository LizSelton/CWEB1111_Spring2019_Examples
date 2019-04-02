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
                zonesCrossed = getNumberOfZones();
                zonesCrossed = checkZones(zonesCrossed);

               

                //SEQUENCE Get Cost
                total = getPrice(zonesCrossed, numberOfPassengers, PASS_CHART);

                output(numberOfPassengers, zonesCrossed, total );



                //Get Primer
                numberOfPassengers = getPrimer();
                

                
            }

            //Notify the user that program has ended
            conclude();
        }//End of main


        //Defining the Module
        static int getPrimer(){
            int numberOfPassengers;
            System.Console.WriteLine("Welcome, this program will calculate the cost of your bus fare based on the number of passengers and zones entered");
            System.Console.WriteLine($"To check price, please enter the number of passengers or enter -1 to exit the program");
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

        static int checkZones(int zones){
                while(zones < 1 || zones > 3){
                    System.Console.WriteLine("Invalid entry, please enter a value thats between 1 and 4");
                    zones = Convert.ToInt32(Console.ReadLine());
                }
            return zones;
        }

        static int getNumberOfZones(){
            int zonesCrossed;
            System.Console.WriteLine("Please enter the number of zones crossed");
              return  zonesCrossed = Convert.ToInt32(Console.ReadLine());
        }

        static double getPrice(int zones, int pass, double [ , ] PASS_CHART){



            double total  = PASS_CHART[pass-1, zones];
            return total;

        }

        static void output(int pass, int zones, double total){
            
                System.Console.WriteLine($"For {pass} passengers and {zones} zones crossed, your ticket charge will be {total.ToString("c")}");
        }

        static void conclude(){
            System.Console.WriteLine("End of Program");
        }
    }
}
