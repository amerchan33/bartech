using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Helpers;

namespace API.Interfaces
{
    public interface IWorkerRepository
    {
         Task<List<workerDto>> GetWorkersAsync(WorkerParams workerParams); 
    }
}