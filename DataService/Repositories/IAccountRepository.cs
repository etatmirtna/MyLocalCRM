using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IAccountRepository
{
    Task<Account?> GetByIdAsync(Guid id);
    Task<IEnumerable<Account>> GetAllAsync();
    Task AddAsync(Account account);
    Task UpdateAsync(Account account);
    Task DeleteAsync(Guid id);
}
