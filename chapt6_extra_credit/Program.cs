using System;

namespace chapt6_extra_credit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program that populates an array using iteration and outputting array
           //DECLARATIONS
            int [] count = new int[12];
            int userInput;
            int w =0;
           
            while(w < count.Length){
                System.Console.WriteLine($"Please enter a value for {w+1} ");
                userInput = Convert.ToInt32(Console.ReadLine());
                count[w] = userInput;
                w++;

            }
            //Increment through array and output
            /** for(var i = 0; i < count.Length; i++){
                System.Console.WriteLine(count[i]);
            }*/

            //Looping structure - that decrements through array and output
            for(var i = count.Length -1; i >= 0; i--){
                System.Console.WriteLine(count[i]);
            }
        }
    }
}
