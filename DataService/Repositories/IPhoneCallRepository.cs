using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IPhoneCallRepository
{
    Task<PhoneCall?> GetByIdAsync(Guid id);
    Task<IEnumerable<PhoneCall>> GetAllAsync();
    Task AddAsync(PhoneCall phoneCall);
    Task UpdateAsync(PhoneCall phoneCall);
    Task DeleteAsync(Guid id);
}
