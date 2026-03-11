using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataService.Models;

namespace DataService.Repositories;

public interface IChatRepository
{
    Task<ChatMessage?> GetByIdAsync(Guid id);
    Task<IEnumerable<ChatMessage>> GetAllAsync();
    Task AddAsync(ChatMessage chat);
    Task UpdateAsync(ChatMessage chat);
    Task DeleteAsync(Guid id);
}
