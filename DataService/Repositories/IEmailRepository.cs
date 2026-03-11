using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IEmailRepository
{
    Task<EmailMessage?> GetByIdAsync(Guid id);
    Task<IEnumerable<EmailMessage>> GetAllAsync();
    Task AddAsync(EmailMessage email);
    Task UpdateAsync(EmailMessage email);
    Task DeleteAsync(Guid id);
}
