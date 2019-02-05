using  System;

namespace metlife_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLRATIONS
            int salesPersonId, numberOfPol, highPerformer;
            int LOWER_LIMIT = 5, HIGHER_LIMIT = 10, EXIT = -999;


            Console.WriteLine("Welcome to MetLife Insurance, this program determines where or not you are a high performer.  To get started, please enter a salesperson id number");
            salesPersonId = Convert.ToInt32(Console.ReadLine());  //Primer

            while(salesPersonId != EXIT){
                System.Console.WriteLine("Please enter the number policies you sold last month");
                numberOfPol = Convert.ToInt32(Console.ReadLine());

                if(numberOfPol >= LOWER_LIMIT || numberOfPol <= HIGHER_LIMIT){
                    System.Console.WriteLine(salesPersonId + " sold between " + LOWER_LIMIT + " and  " +HIGHER_LIMIT);  
                }else{
                    System.Console.WriteLine(salesPersonId + " did not sell between " + LOWER_LIMIT + " and  " +HIGHER_LIMIT);
                }


                //Ask Primer Again
                System.Console.WriteLine( "To run the program again, please enter another salesperson id number or enter -999 to exit the program"  );
                salesPersonId = Convert.ToInt32(Console.ReadLine());  //Primer
               
            }//end of Main
        System.Console.WriteLine( "Thanks for using this program");
        }
    }
}
