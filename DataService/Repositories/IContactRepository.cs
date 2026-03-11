using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IContactRepository
{
    Task<Contact?> GetByIdAsync(Guid id);
    Task<IEnumerable<Contact>> GetAllAsync();
    Task AddAsync(Contact contact);
    Task UpdateAsync(Contact contact);
    Task DeleteAsync(Guid id);
}
