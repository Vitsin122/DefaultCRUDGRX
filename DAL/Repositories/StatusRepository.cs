using DefaultCRUDGRX.DAL.Context;
using DefaultCRUDGRX.DAL.Interfaces;
using DefaultCRUDGRX.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DefaultCRUDGRX.DAL.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private ToDoContext context;
        public StatusRepository(ToDoContext context)
        {
            this.context = context;
        }

        public async Task<ICollection<Status>> GetAllAsync()
        {
            return await context.Statuses.ToListAsync();
        }

        public async Task<Status?> GetStatusByNameAsync(string name)
        {
            return await context.Statuses.FirstOrDefaultAsync(u => u.Status_Name == name);
        }
    }
}
