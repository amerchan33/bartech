using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Helpers;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    public class WorkerController: BaseApiController
    {
        private readonly IWorkerRepository _workerRepository;
        public WorkerController(IWorkerRepository workerRepository)
        {
            _workerRepository = workerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<workerDto>>> GetWorkers([FromQuery]WorkerParams workerParams){
           var workers = await _workerRepository.GetWorkersAsync(workerParams);

           return Ok(workers);
        }

    }
}