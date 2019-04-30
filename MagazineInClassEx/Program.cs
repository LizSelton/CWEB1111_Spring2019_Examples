using System;

namespace MagazineInClassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            MagazineSubscription[] magList = new MagazineSubscription[2];
            string magName, subscriberName;
            int remainingMonths;

            //Looping Structure
            for(var i = 0; i < magList.Length; i++)
            {

                //Create  a new instance for each iteration
                magList[i] = new MagazineSubscription();

                Console.WriteLine("Please enter the subscriber name");  //Sequence
                subscriberName = Console.ReadLine();  //Sequence
                magList[i].SubscriberName = subscriberName;

                Console.WriteLine("Please enter the magazine name:");
                magName = Console.ReadLine();
                magList[i].MagazineName = magName;

                Console.WriteLine($"Please enter the remaining months for {magName}" );
                remainingMonths = Convert.ToInt32(Console.ReadLine());
                magList[i].NumberOfMonthsRemaining = remainingMonths;


            }//End the for loop

            for(var w = 0; w < magList.Length; w++)
            {
                Console.WriteLine(magList[w].ToString());
            }
        }//end of main method

        //Create a method that
        static void deductMagMonth(MagazineSubscription aMag)
        {
           


        }
    }

    class MagazineSubscription
    {

        public string SubscriberName { get; set; }
        public string MagazineName { get; set; }
        public int NumberOfMonthsRemaining { get; set; }

        public override string ToString()
        {
            return String.Format($"Subscriber Name:  {SubscriberName}   Magazine Name:  {MagazineName}  Remaining Months:  {NumberOfMonthsRemaining}");
        }
    }
}
