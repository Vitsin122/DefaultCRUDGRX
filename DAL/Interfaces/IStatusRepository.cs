using DefaultCRUDGRX.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.Interfaces
{
    public interface IStatusRepository
    {
        Task<Status?> GetStatusByNameAsync(string name);
        Task<ICollection<Status>> GetAllAsync();
    }
}
