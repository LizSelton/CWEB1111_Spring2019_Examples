using System;

namespace extraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
          //DECLATATIONS
            double numberA;
            double numberB;
            double EXIT= 00.00;
            double primer;

        //INPUTS
        System.Console.WriteLine("Thank you for entering the program");
        System.Console.WriteLine("Please enter your first number");
        numberA = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Please enter your second number");
        numberB = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("To add please type '1'. To subtract please type '2'.");
        primer = Convert.ToDouble(Console.ReadLine());

            //Housekeeping
            while(numberA != EXIT){
                getChoice(numberA, numberB, primer);
            //    sum( numberA, numberB);
            //    difference(numberA, numberB);
                

            System.Console.WriteLine("To exit, please type '00.00'. to continue please type your first number");
            numberA = Convert.ToDouble(Console.ReadLine());
                if(numberA != EXIT){
                System.Console.WriteLine("Please enter your second number");
                numberB = Convert.ToDouble(Console.ReadLine());
                }
            }


    
        }
        static double sum(double numA, double numB){
            double sum = numA + numB;
            System.Console.WriteLine($"{numA} + {numB} = {sum}");
            return sum;
           }
        static double difference(double numC, double numD){
            double subtraction = numC - numD;
            System.Console.WriteLine($"{numC} - {numD} = {subtraction}");
            return subtraction;

        }
        static void getChoice(double numE, double numF,  double primer){
           
            if (primer == 1){
                sum(numE, numF);
            }else{
                difference(numE, numF);
            }
        }
    }
}




