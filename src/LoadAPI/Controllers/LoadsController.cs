using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LoadAPI.Data;
using LoadAPI.Models;
using AutoMapper;
using LoadAPI.Dtos;

namespace LoadAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // provide Automatic 400 Error response, problem details and binding sourse 
    public class LoadsController:ControllerBase //Can inherit from Controller if View needed, othervise ControllerBase used for inheritance 
    {
        private readonly ILoadAPIRepo _repository;
        private readonly IMapper _mapper;
        public LoadsController(ILoadAPIRepo repository, IMapper mapper)
        {
            _repository=repository;
            _mapper=mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<LoadReadDto>> GetAllLoads()
        {
            var loadItems = _repository.GetAllLoads();
            return Ok(_mapper.Map<IEnumerable<LoadReadDto>>(loadItems));
        }

        [HttpGet("{id}")]
        public ActionResult<Load> GetLoadById(int id)
        {
            var loadItems=_repository.GetLoadById(id);
            if(loadItems==null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<LoadReadDto>(loadItems));
        }
    }
}