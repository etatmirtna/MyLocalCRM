using System.Collections.Generic;
using DataService.Models;

namespace DataService.Repositories;

public interface IRouter
{
    // Returns initial processor name and optionally route attributes
    (string processor, IDictionary<string, object>? attributes) DetermineInitialProcessor(Interaction interaction);
}
