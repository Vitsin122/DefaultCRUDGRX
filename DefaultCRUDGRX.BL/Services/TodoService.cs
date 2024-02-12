using DefaultCRUDGRX.BL.DTO;
using DefaultCRUDGRX.BL.Interfaces;
using DefaultCRUDGRX.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.BL.Services
{
    public class TodoService : ITodoService
    {
        private ToDoUOF _todoUOF;

        public TodoService(ToDoUOF ToDoUOF)
        {
            _todoUOF = ToDoUOF;
        }
        public Task<int> CreateToDoAsync(ToDoDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteTodoAsync(ToDoDTO modelDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ToDoDTO>> GetAllToDoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoDTO> GetToDoByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateToDoAsync()
        {
            throw new NotImplementedException();
        }
    }
}
