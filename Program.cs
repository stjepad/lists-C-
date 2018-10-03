using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main()
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
        planetList.Add("Jupiter");
        planetList.Add("Saturn");
            List<string> lastPlanetsList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(lastPlanetsList);
            planetList.Insert(2,"Earth");
            planetList.Insert(1,"Venus");
            planetList.Add("Pluto");
            planetList.Remove("Pluto");
        // planetList.ForEach(planet => Console.WriteLine(planet));

        List<string> rockyPlanets = planetList.GetRange(0,4);
        // rockyPlanets.ForEach(rockyPlanet => Console.WriteLine(rockyPlanet));


            // Create a list of dictionaires
            List<Dictionary<string, string>> Probes = new List<Dictionary<string, string>>();


            //  Create a dictionary for each planet and add {"Key", "Value"}
                    Dictionary<string, string> Venus = new Dictionary<string, string>(){{"Venus","Sputnik 19"}};
                    Dictionary<string, string> Mercury = new Dictionary<string, string>(){{"Mercury","Messenger"}};
                    Dictionary<string, string> Earth = new Dictionary<string, string>(){{"Earth","Giotto"}};
                    Dictionary<string, string> Jupiter = new Dictionary<string, string>(){{"Jupiter","Ulysses"}};
                    Dictionary<string, string> Mars = new Dictionary<string, string>(){{"Mars","Mariner 3"}};
                    Dictionary<string, string> Saturn = new Dictionary<string, string>(){{"Saturn","Voyager 1"}};
                    Dictionary<string, string> Uranus = new Dictionary<string, string>(){{"Uranus","Voyager 2"}};
                    Dictionary<string, string> Neptune = new Dictionary<string, string>(){{"Neptune","Voyager 2"}};

            // use .Add to add the dictionary of planets to the dictionary list of Probes
            Probes.Add(Venus);
            Probes.Add(Mercury);
            Probes.Add(Earth);
            Probes.Add(Jupiter);
            Probes.Add(Mars);
            Probes.Add(Saturn);
            Probes.Add(Uranus);
            Probes.Add(Neptune);

            // iterate over every taco that we call planet in planetList
            // this spits out every planet individually
            foreach(string planet in planetList)
            {
                // create a new list of strings. call it completedList
                List<string> completedList = new List<string>();
                // foreach dictionarry string string . example {"Venus","Sputnik 19"} in probes.
                foreach (Dictionary<string, string> item in Probes)
                {
                    // foreach KeyValuePair (which means separate the strings into individuals) in item aka the stuff (the arguements)
                    foreach (KeyValuePair<string, string> stuff in item)
                    {
                        // if the stuff.key aka first first string arguement super-equals planets
                        if (stuff.Key == planet)
                        {
                            // .Add the stuff.Value to the previously created list
                            completedList.Add(stuff.Value);
                        }
                        // Console.WriteLine(item);
                        // Console.WriteLine(stuff);

                    }

                }
                // foreach item that is a string in the list called the completedList
                foreach (string item in completedList)
                {
                // console log the planet and item
                Console.WriteLine($"{planet}: {item}");

                }

            }
        }
    }
}
