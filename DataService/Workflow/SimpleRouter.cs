using System.Collections.Generic;
using DataService.Models;
using DataService.Repositories;

namespace DataService.Workflow;

public class SimpleRouter : IRouter
{
    public (string processor, IDictionary<string, object>? attributes) DetermineInitialProcessor(Interaction interaction)
    {
        // Very simple routing: choose processor by interaction type
        var type = interaction.InteractionType?.ToLowerInvariant() ?? string.Empty;
        return type switch
        {
            "phonecall" => ("Default", null),
            "email" => ("Default", null),
            "chat" => ("Default", null),
            _ => ("Default", null)
        };
    }
}
