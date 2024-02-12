using DefaultCRUDGRX.BL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.BL.Interfaces
{
    public interface ITodoService
    {
        Task<int> DeleteTodo(ToDoDTO modelDTO);
        Task<ICollection<ToDoDTO>> GetAllToDoAsync();
        Task<ToDoDTO> GetToDoByNameAsync(string name);
        Task<int> CreateToDoAsync(ToDoDTO modelDTO);
        Task<int> UpdateToDoAsync();

    }
}
