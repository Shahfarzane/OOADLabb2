using System;
using System.Collections.Generic;
using AstronautsConsole.Domain;
using AstronautsConsole.Domain.Entities;

namespace AstronautsConsole.Presentation
{

    public class ViewModel
    {
        private IAstronautRepository Repository;

        public ViewModel(IAstronautRepository repository)
        {
            this.Repository = repository;
        }

        public void ShowListOfAstronauts()
        {
            AstronautsInSpace(Repository.GetAstronauts());
        }

        public void AstronautsInSpace(List<Astronaut> Astronauts)
        {
            if (Astronauts is null)
            {
                throw new ArgumentNullException(nameof(Astronauts));
            }


            Console.WriteLine("Astronauts in space:  " + Astronauts.Count) ;


            foreach (Astronaut astronaut in Astronauts)
            {
                
                string isISS = (astronaut.Craft == "ISS") ? "the International Space Station" : astronaut.Craft;
                Console.WriteLine(astronaut.Name + " is stationed on " + isISS);
            }
        }
    }
}