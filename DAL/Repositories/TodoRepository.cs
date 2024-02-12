using DefaultCRUDGRX.DAL.Context;
using DefaultCRUDGRX.DAL.Interfaces;
using DefaultCRUDGRX.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.Repositories
{
    public class TodoRepository : ITodoRepository
    {

        private ToDoContext _context;

        TodoRepository(ToDoContext _context)
        {
            this._context = _context;
        }
        public async Task<int> DeleteAsync(ToDo model)
        {
            await Task.Run(() => _context.ToDos.Remove(model));
            return model.Id;
        }

        public async Task<ICollection<ToDo>> GetAllAsync()
        {
            return await _context.ToDos.ToListAsync();
        }

        public async Task<ToDo?> GetByNameAsync(string name)
        {
            return await _context.ToDos.FirstOrDefaultAsync(u => u.Name == name);
        }

        public async Task<int> UpdateAsync(ToDo model)
        {
            ToDo toDo = await _context.ToDos.FirstOrDefaultAsync(u => u.Id == model.Id);

            if (toDo == null)
                throw new DbUpdateException(message: "Ne nashol tudushku :)");

            toDo.Name = model.Name;
            toDo.Description = model.Description;
            toDo.Status_ID = model.Status_ID;

            await Task.Run(() => _context.ToDos.Update(toDo));

            return toDo.Id;
        }
        public async Task<int> CreateAsync(ToDo model)
        {
            await _context.ToDos.AddAsync(model);
            return model.Id;
        }

    }
}
