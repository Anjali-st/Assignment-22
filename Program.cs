using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment_22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Source source = new Source
            {
                Id = 111,
                Name = "Jack Sparrow",
                Age = 23
            };

            Destination destination = new Destination()
            {
                Description = "Welcome to IMF...",
                MissionAcceptance = "Yes",
                PrevMissionAccomplished = true,

            };

            PropertyMapper.MapProperties(source, destination);

            // Display the values of the properties in the Destination class
            Console.WriteLine("Destination Properties:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Description: {destination.Description}");
            Console.WriteLine($"Mission Acceptance Status: {destination.MissionAcceptance}");
            Console.WriteLine($"Status of Previous Mission Accomplishment: {destination.PrevMissionAccomplished}");
            Console.ReadKey();
        }
    }

}



