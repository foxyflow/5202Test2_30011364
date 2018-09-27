using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202Test2_30011364LukeFox
{
    class Program /////Developed by: Luke Fox Test 2////////Birds of Prey //////////////////////////DC//////////
        
        //This program is for identifying individual birds at the Bird of Prey Centre in Rotorua NZ

    {
        static void Main(string[] args)
        { //Please update your Bird data here:
            Console.WriteLine("Please enter bird namne: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the bird's species type: ");
            string species = Console.ReadLine();
            Console.WriteLine("Please enter the sex of the bird: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Please enter the bird's weight: (DO-NOT include the unit of measurement) ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the bird's BandNo: ");
            string bandno = Console.ReadLine();
            Console.WriteLine("Thank you");

            //object of Bird class:
            Bird b1 = new Bird(name, species, sex, weight, bandno);

            //Displaying the returned method (displayBird)
            Console.WriteLine(b1.BirdInformation());
            Console.ReadLine();
        }
        

    }
    class Bird
    {   //5 auto implemented properties  
        public string Name { get; set; }
        public string Species { get; set; }
        public string Sex { get; set; }
        public double Weight { get; set; }
        public string BandNo { get; set; }

        //Construstor List 
        public Bird (string _name, string _species, string _sex, double _weight, string _bandno)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            BandNo = _bandno;
        }
        
        public string BirdInformation() //AKA displayBird //display bird method: returns all the bird's info to the Bird class
        {
            Console.WriteLine("Bird object created and default data loaded: ");

            return $"Bird's name: {Name}. Bird's species type: { Species}. Bird's sex: {Sex}. " +
                $"Bird's weight: {Weight}. Bird's band number: {BandNo}";     
        }
    } 
}
