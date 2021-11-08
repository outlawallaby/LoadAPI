using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LoadAPI.Data;
using LoadAPI.Models;

namespace LoadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // provide Automatic 400 Error response, problem details and binding sourse 
    public class LoadsController:ControllerBase //Can inherit from Controller if View needed, othervise ControllerBase used for inheritance 
    {
        private readonly ILoadAPIRepo _repository;
        public LoadsController(ILoadAPIRepo repository)
        {
            _repository=repository;
        }

        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] {"this","is","hard","coded"};
        // }
        // To get all Mock data 
        [HttpGet]
        public ActionResult<IEnumerable<Load>> GetAllLoads()
        {
            var loadItems = _repository.GetAllLoads();
            return Ok(loadItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Load> GetLoadById(int id)
        {
            var loadItems=_repository.GetLoadById(id);
            if(loadItems==null)
            {
                return NotFound();
            }
            return Ok(loadItems);
        }
    }
}