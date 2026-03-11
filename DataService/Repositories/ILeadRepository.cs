using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface ILeadRepository
{
    Task<Lead?> GetByIdAsync(Guid id);
    Task<IEnumerable<Lead>> GetAllAsync();
    Task AddAsync(Lead lead);
    Task UpdateAsync(Lead lead);
    Task DeleteAsync(Guid id);
}
