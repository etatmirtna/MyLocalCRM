using System.Threading;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IInteractionHandler
{
    string Name { get; }
    Task<HandlerResult> HandleAsync(WorkflowTicket ticket, CancellationToken ct);
}
