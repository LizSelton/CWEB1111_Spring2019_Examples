using System;

namespace oop_artist_ex
{
    class Program
    {
        //Create a list of Artist
        static void Main(string[] args)
        {
            
            Artist anArtist = new Artist();  //Instantiation

           

            anArtist.setName("Van Gogh");
            anArtist.setSpecialty("Canvas Painting");
            anArtist.setTypeOfArtist("Painter");
            anArtist.setHourlyFee(1000.00);
            anArtist.setAvgAnnualJobs(3);
            

           /**  System.Console.WriteLine( $"Name : {anArtist.getName()}  Specialty: {anArtist.getSpecialty()} Type Of Artist: {anArtist.getTypeOfArtist()} Hourly Fee: {anArtist.getHourlyFee()}  Est. Annual Jobs: {anArtist.getAvgAnnualJobs()}  Estimated Annual Payout: {anArtist.getEstimatedAnnualPayout().ToString("c")}");**/

           Console.WriteLine(anArtist.ToString());
            
        }
    }

    public class Artist{
        
        //DECLARING ATTRIBUTES EACH ARTIST WILL HAVE
        private string name;
        private string  specialty;
        private string typeOfArtist;

        private double hourlyFee;

        private int avgAnnualJobs;

        private double estimatedAnnualPayout;  //only need a getter here

        //GETTER and SETTERS
        //SETTING name
        public void setName(string aName){
            name = aName;
        }

        //Getting name
        public string getName(){
            return name;
        }

        public void setHourlyFee(double fee){
            hourlyFee = fee;
        }

        //Getting name
        public double getHourlyFee(){
            return hourlyFee;
        }

        public void setAvgAnnualJobs(int avgJobs){
            avgAnnualJobs = avgJobs;
            calcEstimatedAnnualPayout();
        }

        public int getAvgAnnualJobs(){
            return avgAnnualJobs;
        }

        public double getEstimatedAnnualPayout(){
            return estimatedAnnualPayout;
        }

        //setting speciality
        public void setSpecialty(string spec){
            specialty = spec;

        }

        //getting specialty
        public string getSpecialty(){
            return specialty;
        }

        public void setTypeOfArtist(string type){
            typeOfArtist = type;
        }

        public string getTypeOfArtist(){
            return typeOfArtist;
        }

        //Working Method is going to calculate the estimatedAnnualPayout

        private void calcEstimatedAnnualPayout(){
            estimatedAnnualPayout = hourlyFee * avgAnnualJobs; 
        }

        //Inherited method derived from Object class
        public override string ToString(){

            return String.Format($"Name: { name } Specialty: { specialty} Type of Artist: { typeOfArtist} Hourly Fee: { hourlyFee} Average Annual Jobs: {avgAnnualJobs} Estimate Annual Payout: {estimatedAnnualPayout.ToString("c")} ");

        }



    }
}
