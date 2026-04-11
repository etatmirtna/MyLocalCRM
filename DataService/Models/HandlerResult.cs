using System;

namespace DataService.Models;

public record HandlerResult
{
    public bool Completed { get; init; }
    public string? NextProcessor { get; init; }
    public int DelaySeconds { get; init; }
    public string? ResultJson { get; init; }
}
