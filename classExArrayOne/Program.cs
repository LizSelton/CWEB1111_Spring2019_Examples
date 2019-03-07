using System;

namespace classExArrayOne
{
    class Program
    {
        static void Main(string[] args)
        {
           int dep;
           int [] counts = {0,0,0,0,0,0};
           int QUIT = 999;

           System.Console.WriteLine("Enter dependents or QUIT to quit");
           dep = Convert.ToInt32(Console.ReadLine());

           while(dep != QUIT){
               //defensively program to ensure a number between 0 and 5
               while(dep > 5 || dep < 0){
                   System.Console.WriteLine( "Invalid, entry please enter a value between 0 and 5");
                   dep = Convert.ToInt32(Console.ReadLine());
               }
               counts[dep] += 1;

               System.Console.WriteLine("Enter dependents or QUIT to quit");
               dep = Convert.ToInt32(Console.ReadLine());

           }
        for(var x = 0; x < counts.Length; x++){
            System.Console.WriteLine($"For employees with {x} dependents we have a count of: {counts[x]}");
        }
        }//End of main
    }
}
