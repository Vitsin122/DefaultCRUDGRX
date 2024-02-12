using DefaultCRUDGRX.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.Interfaces
{
    public interface ITodoRepository
    {
        Task<ICollection<ToDo>> GetAllAsync();
        Task<ToDo?> GetByNameAsync(string name);
        Task<int> DeleteAsync(ToDo name);
        Task<int> UpdateAsync(ToDo model);
        Task<int> CreateAsync(ToDo model);
    }
}
