using System;
using System.Collections.Generic;

namespace WNBA
{
    class Program
    {
        static void Main(string[] args)
        {
           //DECLARATIONS
           int teamSelection;
           int EXIT = -1;

           //Team Array
           string[] TEAMS = {"Atlanta Dream", "Chicago Sky", "Connecticut Sun", "Dallas Wings", "Indiana Fever", "Los Angeles Sparks", "Minnesota Lynx", "New York Liberty", "Phoenix Mercury", "San Antonio Stars", "Seattle Storm", "Washington Mystics"};

           string [] COACH_TITLES = {"Head Coach", "Assistant Coach", "Assistant Coach","Assistant Coach","Assistant Coach", };

           string [] MONTHS = { "Jan", "Feb", "Mar", "April", "May", "June", "July", "Aug","Sept.", "Oct.","Nov", "Dec"};
           int x;

           double PAY_INCREASE_MAY = 2000.00, HEAD_COACH_PAY = 10000.00, ASSIST_COACH_PAY = 8000.00;
           double  pay;
           double payHead, payAssist;
           double headCoachAccum, assistCoachAccum;
           


           System.Console.WriteLine("Welecome, this program outputs the payroll for the selected team please input a team number from the list below");
           //Generate the available teams - Looping structure

            for(x = 0; x < TEAMS.Length; x++){
                System.Console.WriteLine($"Please enter {x} for {TEAMS[x]}");
            }

           teamSelection = Convert.ToInt32(Console.ReadLine());

            //Looping structure to allow the end-user to continously iterate
            do{
                Console.Clear();
                //Defensively program to ensure that value enter is between 0 and 11
                while(teamSelection < 0 || teamSelection > 11){
                    System.Console.WriteLine( "Invalid Entry, please enter a value between 0 and 11");
                    teamSelection = Convert.ToInt32(Console.ReadLine());
                }
                System.Console.WriteLine( $"Listed below is the pay stubs for Team {TEAMS[teamSelection]}");
                //Looping structure that controls the months
                for(var i = 0; i < MONTHS.Length; i++){

                    //Decision structure to determine if the month is May
                    if(i == 4){
                        payHead = HEAD_COACH_PAY +  PAY_INCREASE_MAY;
                        payAssist = ASSIST_COACH_PAY + PAY_INCREASE_MAY;
                    }else{
                        payHead = HEAD_COACH_PAY;
                        payAssist = ASSIST_COACH_PAY;
                    }
                    //Output the coaches loop
                    for(var z = 0; z < COACH_TITLES.Length; z++){
                        //Looping structure to output the pay difference for head coach and assistant coach
                        if(z == 0){
                            System.Console.WriteLine($"********** PAY STUB for Month {MONTHS[i]} for team { TEAMS[teamSelection]}*********");

                            System.Console.WriteLine($"The {COACH_TITLES[z]} pay is {payHead.ToString("c")}");
                            System.Console.WriteLine( "**********End of pay stub *****************");
                            System.Console.WriteLine("");
                        }else{
                            System.Console.WriteLine($"********** PAY STUB for Month {MONTHS[i]} for team { TEAMS[teamSelection]}*********");

                            System.Console.WriteLine($"The {COACH_TITLES[z]} pay is {payAssist.ToString("c")}");
                            System.Console.WriteLine("**********End of pay stub *****************");
                            System.Console.WriteLine("");
                        }
                    }
                    System.Console.WriteLine("");

                }

                System.Console.WriteLine( "To enter another team, please enter from the list below or enter -1 to exit the program");
                           //Generate the available teams - Looping structure
            for(x = 0; x < TEAMS.Length; x++){
                System.Console.WriteLine($"Please enter {x} for {TEAMS[x]}");
            }
           teamSelection = Convert.ToInt32(Console.ReadLine());

            }while(teamSelection != EXIT);
        System.Console.WriteLine(  "Program has concluded");


        }
    }
}
