using DefaultCRUDGRX.DAL.Context;
using DefaultCRUDGRX.DAL.Interfaces;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.UnitOfWork
{
    public class ToDoUOF
    {
        private ITodoRepository _todoRepository;
        private IStatusRepository _statusRepository;
        private ToDoContext _toDoContext;

        public ToDoUOF(ToDoContext context, ITodoRepository todoRepository, IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
            _todoRepository = todoRepository;
            _toDoContext = context;
        }

        public ITodoRepository TodoRepository
        {
            get { return _todoRepository; }
        }
        public IStatusRepository StatusRepository
        {
            get { return _statusRepository; }
        }

        public async Task Save()
        {
            await _toDoContext.SaveChangesAsync();
        }
    }
}
