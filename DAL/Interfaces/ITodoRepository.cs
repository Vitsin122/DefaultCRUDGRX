using DefaultCRUDGRX.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.Interfaces
{
    public interface ITodoRepository
    {
        Task<ICollection<ToDo>> GetAll();
        Task<ToDo> GetByName(string name);
        Task<int> Delete(ToDo name);
        Task<int> Update(ToDo model);
    }
}
