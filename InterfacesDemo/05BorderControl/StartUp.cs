using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiable = new List<IIdentifiable>();
            string entrants = Console.ReadLine();
            while (entrants != "End")
            {
                string[] entrantDetails = entrants.Split();
                if (entrantDetails.Length>2)
                {
                    string name = entrantDetails[0];
                    int age = int.Parse(entrantDetails[1]);
                    string id = entrantDetails[2];
                    var citizen = new Citizen(name, age, id);
                    identifiable.Add(citizen);
                }
                else
                {
                    string model = entrantDetails[0];
                    string id = entrantDetails[1];
                    Robot robot = new Robot(model, id);
                    identifiable.Add(robot);
                }
                entrants = Console.ReadLine();
            }
            string fakeIds = Console.ReadLine();
            var detained = identifiable.Where(i => i.Id.EndsWith(fakeIds)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, detained));
        }
    }
}

