using System;
namespace AstronautsConsole.Domain.Entities
{
    public class Astronaut
    {
        
        public Astronaut() { }
        public Astronaut(string name, string craft)
        {
            Name = name;
            Craft = craft;
        }

        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Craft { get; set; }
    }
}