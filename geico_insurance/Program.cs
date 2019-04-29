//C.Fulton
using System;
using System.Collections.Generic;

namespace geico_insurance
{
    class Program
    {
        public static double  HEALTH_POLICY_COST = 550.00, AUTO_POLICY_COST = 225.00;
        static List<Policy> policyList = new List<Policy>();
        static void Main(string[] args)
        {
            //DECLARATIONS
            int EXIT = -1;

           
           
            int policyNum, userInput;

            policyNum = houseKeeping(); //Calling or involking the housekeeping method
            while(!(policyNum == EXIT)){

                //get user policy selection
                userInput = getPreferredPolicy(policyNum);
                
                //Validate user entry for policy selection
                userInput = validatePolicySelection(userInput);  //Calling or involking

                //Module that sets the premium, pass in user Input variable
                setPremium(userInput, policyNum, userInput);  //Call or involk

                policyNum = getPrimer();
            }

            conclude();
        }//End of main

        //This is welcome the end-user and get initial input
        static int houseKeeping(){
            //DECLARE
            int polNum;
            System.Console.WriteLine("Welcome, this program will output the cost of selected insurance policy");
            System.Console.WriteLine("Please enter a 5 digit code for the policy number"); 
            polNum = Convert.ToInt32(Console.ReadLine());

            return polNum;

        }
        //Module that primes the user for input and returns an interger
        static int getPrimer(){
            //DECLARE
            int polNum;
        

            System.Console.WriteLine("To enter another policy, Please enter a 5 digit code for the policy number or enter -1 to exit the program");
            polNum = Convert.ToInt32(Console.ReadLine());

            return polNum;

        }
        static void conclude(){

            policyList.ForEach(i => Console.WriteLine(i.ToString()));
            System.Console.WriteLine("Program has concluded");
        }

        //Get user policy type either health or auto, method returns an interger
        static int getPreferredPolicy(int polNum){
            //Delcare local variables
            int polType;
            System.Console.WriteLine($" For {polNum} please enter 1 for Health or 2 for Auto Policy" );
           return polType = Convert.ToInt32(Console.ReadLine());

        }

        //Module that validates or ensure that the policy returns an interger that is 1 or 2
        static int validatePolicySelection(int input){

            while(input != 1 && input != 2){
                System.Console.WriteLine("Invalid entry, please enter 1 for Health or 2 for Auto Policy");
                input = Convert.ToInt32(Console.ReadLine());
            }

            return input;
        }

        static void setPremium(int polSelection,int polNum, int input ){
            double premiumCost;
            string policyTypeValue;
            //Decision structure to determine is they have health or auto
            if(polSelection == 1){
                premiumCost = HEALTH_POLICY_COST;
                policyTypeValue = "HEALTH";
            }else{
                premiumCost = AUTO_POLICY_COST;
                policyTypeValue = "AUTO";
            }


            policyList.Add( new Policy(polNum, policyTypeValue, premiumCost));
            outputInfo(premiumCost, polNum, input);
            
        }

        static void outputInfo(double premiumCost, int polNum, int input){
            if(input == 1){
                System.Console.WriteLine( $"For {polNum} you selected a Health Policy that will cost {premiumCost.ToString("c")}.");
            }else{
                System.Console.WriteLine( $"For {polNum} you selected a Auto Policy that will cost {premiumCost.ToString("c")}.");
            }
        }
    }

    class Policy{

        public int PolicyNum {get; set;}
        public string PolicyType {get; set;}
        public double PolicyPremium {get; set;}

        public Policy(int policy, string polType, double policyPrem){
            PolicyNum = policy;
            PolicyType = polType;
            PolicyPremium = policyPrem;

        }

        //Override the ToString method
        public override string ToString() {
            return String.Format($"Policy Number: {PolicyNum}  Policy Type: { PolicyType} Policy Premium { PolicyPremium}");
        }
    }
}
