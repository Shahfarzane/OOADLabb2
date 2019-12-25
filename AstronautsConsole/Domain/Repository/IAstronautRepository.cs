using System;
using System.Collections.Generic;
using AstronautsConsole.Domain.Entities;

namespace AstronautsConsole.Domain

{
    public interface IAstronautRepository
    {
        List<Astronaut> GetAstronauts();
    }
}
