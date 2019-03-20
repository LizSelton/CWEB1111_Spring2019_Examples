using System;
using System.Collections.Generic;

namespace chapt6_extra_credit
{
    class Program
    {
        static void Main(string[] args)
        {
        //     //Program that populates an array using iteration and outputting array
        //    //DECLARATIONS
        //     int [] count = new int[12];
        //     int highNum, lowNum;
        //     int userInput;
        //     int w =0;
        //     List<int> aList = new List<int>();
           
        //    //Looping structure that allows the user to populate the array
        //     while(w < count.Length){
        //         System.Console.WriteLine($"Please enter a value for {w+1} ");
        //         userInput = Convert.ToInt32(Console.ReadLine());
        //         count[w] = userInput;
        //         w++;

        //     }

        //     highNum = 0;
            
        //     lowNum = count[count.Length-1];
        //     //Looping structure to iterate through all the numbers and decision structure to determine the higest number and th lowest number
        //     for(var i = count.Length -1; i >= 0; i--){
               
        //         //Decison structure to determine the highest number and lowest number
        //         if(count[i]>= highNum){
        //             highNum = count[i];
        //         }else if(count[i] <= lowNum){
        //             lowNum = count[i];
        //         }
        //     }

            



        //     //Looping structure - that decrements through array and output
        //     for(var i = count.Length -1; i >= 0; i--){
        //         System.Console.WriteLine(count[i]);
        //     }
        //     System.Console.WriteLine($"The highest value entered is {highNum} and the lowest number entered is {lowNum}");
        //     System.Console.WriteLine("Program is now concluding");

        // GLOBAL DECLARATIONS
        string authorName;
        int targetAge, booksWritten;
        string EXIT = "STOP";
        int [] bookCount = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        int[] AGE_RANGE = {3, 8, 11, 14};
        int [] AGE_COUNT = {0,0,0,0};
        string[] AGE_RANGE_TEXT = {"In range 0 to 2 age range", "In range 3 to 7 age range", "In range 11 through 13 age range", "14 or older"};
        int x;
        int AGE_LOWER_LIMIT = 0, AGE_UPPER_LIMIT = 16, BOOK_COUNT_LOWER_LIMIT = 0, BOOK_COUNT_UPPER_LIMIT = 40;
        
        
        //Involking HouseKeeping module
        authorName = houseKeeping();
        //Looping Structurce that allows the program to continue until Sentinel value is entered
        while(authorName != EXIT){
            System.Console.WriteLine("Please enter the number of books you have written.  Please enter a value between 0 and 40");
            booksWritten = Convert.ToInt32(Console.ReadLine());

            //Defensively program to ensure that value entered is between 0 and 40
            while(booksWritten < BOOK_COUNT_LOWER_LIMIT || booksWritten > BOOK_COUNT_UPPER_LIMIT){
                System.Console.WriteLine($"Invalid entry, please enter a value that is between{BOOK_COUNT_LOWER_LIMIT} and {BOOK_COUNT_UPPER_LIMIT}");
                booksWritten = Convert.ToInt32(Console.ReadLine());
            }

            //SEQUENCE
            System.Console.WriteLine(  "Please enter the target age you write books for");
            targetAge = Convert.ToInt32(Console.ReadLine());

            //Defensive program to ensure that value entered is between 0 and 16
            while(targetAge < AGE_LOWER_LIMIT || targetAge > AGE_UPPER_LIMIT){
                System.Console.WriteLine($"Invalid entry, please enter a value that is between {AGE_LOWER_LIMIT} and {AGE_UPPER_LIMIT} ");
                targetAge = Convert.ToInt32(Console.ReadLine());
            }

            //Algorithm that determines how many authors have written for a particular age range.
            //Looping structure that determines the index of range.
            x = 3;
            while (targetAge < AGE_RANGE[x] && x > 0){
                x = x-1;
            }

            AGE_COUNT[x]= AGE_COUNT[x] + 1;

           

            System.Console.WriteLine($"To enter another author, please enter the authors name or enter '{EXIT}' to exit the program");
            authorName = Console.ReadLine();
        }
            Console.Clear();
            for(var i = 0; i < AGE_COUNT.Length; i++){
                System.Console.WriteLine($"{AGE_COUNT[i]}  {AGE_RANGE_TEXT[i]}");
            }
        
        }//End of main
        static string houseKeeping(){
            //Local Variables
            string authorName;
            System.Console.WriteLine("Welcome this program gives you a count of how many books each author has written");
            System.Console.WriteLine("To get started, please enter the authors name");
            authorName = Console.ReadLine();
            return authorName;

        }
        
    }

}
