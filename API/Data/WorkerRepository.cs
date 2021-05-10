using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class WorkerRepository : IWorkerRepository
    {
        private readonly DataContext _context;

        public WorkerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<workerDto>> GetWorkersAsync(WorkerParams workerParams)
        {
             var query = 
                    (from worker in _context.Workers                        
                        
                        select new workerDto 
                        { 
                            WorkerId = worker.WorkerId,
                            FullName = worker.FullName,
                            Coordinates = worker.Coordinates
                        }
                    ).AsNoTracking()
                    .AsQueryable();

                if(!string.IsNullOrEmpty(workerParams.FullName))  
                query =  query.Where(d => d.FullName.Contains(workerParams.FullName));


            return await query.ToListAsync();
        }
    }
}