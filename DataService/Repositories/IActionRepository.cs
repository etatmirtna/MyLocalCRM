using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IActionRepository
{
    Task<Action?> GetByIdAsync(Guid id);
    Task<IEnumerable<Action>> GetAllAsync();
    Task AddAsync(Action action);
    Task UpdateAsync(Action action);
    Task DeleteAsync(Guid id);
}
