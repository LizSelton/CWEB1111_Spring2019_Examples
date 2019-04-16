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
            

            System.Console.WriteLine( $"Name : {anArtist.getName()}  Specialty: {anArtist.getSpecialty()} Type Of Artist: {anArtist.getTypeOfArtist()}");
            
        }
    }

    public class Artist{
        
        //DECLARING ATTRIBUTES EACH ARTIST WILL HAVE
        private string name;
        private string  specialty;
        private string typeOfArtist;

        //GETTER and SETTERS
        //SETTING name
        public void setName(string aName){
            name = aName;
        }

        //Getting name
        public string getName(){
            return name;
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

        //Working Method
     


    }
}
