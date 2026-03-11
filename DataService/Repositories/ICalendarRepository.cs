using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface ICalendarRepository
{
    Task<Calendar?> GetByIdAsync(Guid id);
    Task<IEnumerable<Calendar>> GetAllAsync();
    Task AddAsync(Calendar calendar);
    Task UpdateAsync(Calendar calendar);
    Task DeleteAsync(Guid id);
}
