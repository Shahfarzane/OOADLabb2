using System;
using System.Collections.Generic;
using AstronautsConsole.Domain;
using AstronautsConsole.Domain.Entities;

namespace AstronautsConsole.Data.Repository
{
    public class AstronautRepository : IAstronautRepository
    {
        public List<Astronaut> People { get; set; }
        public int Number { get; set; }
        public IAstronautRepository repository;

        //constructors
        public AstronautRepository(IAstronautRepository repository)
        {
            this.repository = repository;
            People = repository.GetAstronauts();
        }

        public AstronautRepository()
        {
        }


        public List<Astronaut> GetAstronauts()
        {
            return People;
        }
    }
}