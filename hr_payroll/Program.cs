using System;

namespace hr_payroll
{
    class hr_department
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string employeeName;
            int deptNum, numbOfHoursWorked;
            double hourlyRate;
            string EXIT = "EXIT";

            string[] DEPART_NAMES = new String[7];

            DEPART_NAMES[0] = "Personnel";
            DEPART_NAMES[1] = "Marketing";
            DEPART_NAMES[2] = "Manufacturing";
            DEPART_NAMES[3] = "Computer Science";
            DEPART_NAMES[4] = "Sales";
            DEPART_NAMES[5] = "Accounting";
            DEPART_NAMES[6] = "Shipping";


            double [] deptPayout = {0,0,0,0,0,0,0};

            employeeName = welcome();

            //Continous Iteration  to allow end-user to enter employees until Sentinel is entered
            do{
                //get department module
                deptNum = getDepartment(employeeName, DEPART_NAMES);

                //get hourly pay

                //get number of hours worked


                //calculate Salary

                //Increment department payout


                //reprompt primer
                



            }while(employeeName != EXIT);

            //output summary of payout

        }//end of main

        static string welcome(){
            string name;

            //SEQUENCE - Intro. and getting initial priming value
            System.Console.WriteLine("Welcome, this program allows you to input employee data and produce a report of how much each department will pay in salary");
            System.Console.WriteLine("Please input your name");
            name = Console.ReadLine();
            return name;

        }


        //returns a valid department number that has been defensively programmed.
        static int getDepartment(string name, string[] DEPT){
            int deptNum;
            //Looping structure - iterate through DEPT names for end-user knows which department to select
            for(var i = 0; i < DEPT.Length; i++){
                System.Console.WriteLine($"Please enter {i} for {DEPT[i]}");
            }
            System.Console.WriteLine($"{name} please enter your deparment number from the list above");
            deptNum = Convert.ToInt32(Console.ReadLine());

            //Calling method to Defensively program to ensure value is between 1 and 6
            checkDepartment(deptNum);
            Console.Clear();

            return deptNum;
        }

        static int checkDepartment(int deptNum){
            //Defensively program to ensure value is between 1 and 6 using looping structure
            while(deptNum < 0 || deptNum > 6){
                System.Console.WriteLine("Invalid Entry, Please enter a number between 0 and 6");
                deptNum = Convert.ToInt32(Console.ReadLine());
            }

            return deptNum;
        }
    }
}
