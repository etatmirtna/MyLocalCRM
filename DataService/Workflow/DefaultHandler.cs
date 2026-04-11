using System.Threading;
using System.Threading.Tasks;
using DataService.Models;
using DataService.Repositories;

namespace DataService.Workflow;

public class DefaultHandler : IInteractionHandler
{
    public string Name => "Default";

    public Task<HandlerResult> HandleAsync(WorkflowTicket ticket, CancellationToken ct)
    {
        // Default behavior: mark completed with no result
        var res = new HandlerResult
        {
            Completed = true,
            ResultJson = "{ \"message\": \"Processed by default handler\" }"
        };

        return Task.FromResult(res);
    }
}
