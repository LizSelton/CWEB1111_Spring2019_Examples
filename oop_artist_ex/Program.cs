using System;

namespace oop_artist_ex
{
    class Program
    {
        //Create a list of Artist
        static void Main(string[] args)
        {
            
            Artist anArtist = new Artist();  //Instantiation
            Artist anArtistTwo = new Artist();  //Instantiation
            Artist [] aListOfArtist = new Artist[3];

            for(var x = 0; x < aListOfArtist.Length; x++){
                aListOfArtist[x] = new Artist("Van Gogh", "Canvas Painting", "Painter", 1000.00, 3);

                /* aListOfArtist[x].Name  = "Van Gogh";
                aListOfArtist[x].Specialty ="Canvas Painting";
                aListOfArtist[x].TypeOfArtist = "Painter";
                aListOfArtist[x].HourlyFee =1000.00;
                aListOfArtist[x].AvgAnnualJobs =3; */


            }

            for(var i = 0; i < aListOfArtist.Length; i++){
                System.Console.WriteLine(aListOfArtist[i].ToString() + "\n");
            }
           


            

           /**  System.Console.WriteLine( $"Name : {anArtist.getName()}  Specialty: {anArtist.getSpecialty()} Type Of Artist: {anArtist.getTypeOfArtist()} Hourly Fee: {anArtist.getHourlyFee()}  Est. Annual Jobs: {anArtist.getAvgAnnualJobs()}  Estimated Annual Payout: {anArtist.getEstimatedAnnualPayout().ToString("c")}");**/

          // Console.WriteLine(anArtist.ToString() + " \n " + anArtistTwo.ToString());
            
        }
    }

    public class Artist{
        
        //DECLARING ATTRIBUTES EACH ARTIST WILL HAVE
        public string Name {get; set;}
        public string  Specialty {get; set;}
        public string TypeOfArtist {get; set;}

        public double HourlyFee {get; set;}

        public int AvgAnnualJobs {get; set;}

        private double EstimatedAnnualPayout; //only need a getter here


        public double getEstimatedAnnualPayout(){
            return EstimatedAnnualPayout;
        }

        //default Constructor

        public Artist(){

        }

        public Artist(string name, string specialty, string typeOfArtist, double hourlyFee, int avgannualjobs){
            Name = name;

            Specialty = specialty;
            TypeOfArtist = typeOfArtist;
            HourlyFee = hourlyFee;
            AvgAnnualJobs = avgannualjobs;
            calcEstimatedAnnualPayout();
        }
        //Working Method is going to calculate the estimatedAnnualPayout

        private void calcEstimatedAnnualPayout(){
            EstimatedAnnualPayout = HourlyFee * AvgAnnualJobs; 
        }

        //Inherited method derived from Object class
        public override string ToString(){

            return String.Format($"Name: { Name } Specialty: { Specialty} Type of Artist: { TypeOfArtist} Hourly Fee: { HourlyFee} Average Annual Jobs: {AvgAnnualJobs} Estimate Annual Payout: {EstimatedAnnualPayout.ToString("c")} ");

        }



    }
}
