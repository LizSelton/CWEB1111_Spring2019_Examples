using System;

namespace humboldt_homes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string salesPersonInitial, salesPersonName, salesPersonWithHigh ="";
            const string CAPITAL_S = "S", CAPITAL_N = "N", CAPITAL_C = "C", LOWERCASE_S = "s", LOWERCASE_N = "n", LOWERCASE_C = "c";
            string UPPER_END = "Z", LOWER_END = "z";
            string ERROR_MESSAGE = "Invalid Initial, please input the initial of  S , N  or Z";
            double grandTotal = 0, saleAmt, nHighSale =0, cHighSale = 0, sHighSale =0;
            

            System.Console.WriteLine("Welcome, this program takes in employee data and determines a grand total and who has the most sales");
            //Getting Primer
            System.Console.WriteLine("Let's get started, please input the salesperson initial to get started");
            salesPersonInitial = Console.ReadLine();

            //Looping structure to continously iterate
            while(salesPersonInitial != UPPER_END  && salesPersonInitial != LOWER_END){
                
                //Defensive Programming to ensure allowed Characters
                while(salesPersonInitial != CAPITAL_S && salesPersonInitial != CAPITAL_N &&salesPersonInitial != CAPITAL_C &&salesPersonInitial != LOWERCASE_S && salesPersonInitial != LOWERCASE_N && salesPersonInitial != LOWERCASE_C ){
                    System.Console.WriteLine(ERROR_MESSAGE);
                    System.Console.WriteLine("Please enter C, N or S");
                    salesPersonInitial = Console.ReadLine();
                }

                //get salesperson name
                System.Console.WriteLine("Please enter the sales person name");
                salesPersonName = Console.ReadLine();

                System.Console.WriteLine($"Please enter the sale amount for {salesPersonName}");
                saleAmt = Convert.ToDouble(Console.ReadLine());

                //Making a decision to assign sales amount to correct employee
                      switch (salesPersonInitial)
                        {
                            case CAPITAL_C:
                                 cHighSale = cHighSale + saleAmt;
                                break;
                            case LOWERCASE_C:
                                 cHighSale = cHighSale + saleAmt;
                                break;
                            case CAPITAL_N:
                                 nHighSale += saleAmt;
                                break;
                            case LOWERCASE_N:
                                 nHighSale += saleAmt;
                                break;
                            case CAPITAL_S:
                                 sHighSale += saleAmt;
                                break;
                            case LOWERCASE_S:
                                 sHighSale += saleAmt;
                                break;
                            default:
                                Console.WriteLine("Something went Horribly wrong");
                                break;
                        }

                //Determing the naem of the highest salesperson
            
               
                   if(sHighSale > nHighSale){
                       salesPersonWithHigh = "Silas";
                   }else {
                       salesPersonWithHigh = "Noah";
                   }

                   if(cHighSale > sHighSale){
                       salesPersonWithHigh = "Chris";
                   }else{
                       salesPersonWithHigh = "Silas";
                   }

                   if(nHighSale > cHighSale){
                       salesPersonWithHigh = "Noah";
                   }else{
                       salesPersonWithHigh = "Chris";
                   }

               
                
                //Ask the primer again
                System.Console.WriteLine("To enter a another salesperon, please input the salesperson initial to get started");
                salesPersonInitial = Console.ReadLine();



                
            }//end of our while
            grandTotal = nHighSale + sHighSale + cHighSale;
            System.Console.WriteLine("The program has concluded");
            System.Console.WriteLine($"The total for all employees entered is: {grandTotal.ToString("c")} the employee with the highest sales is: {salesPersonWithHigh} ");
        }//end of main
    }
}
