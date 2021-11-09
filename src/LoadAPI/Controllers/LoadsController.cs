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
        [HttpPut("{id}")]
        public ActionResult UpdateLoad(int id, LoadUpdateDto loadUpdateDto)
        {
            var loadModelFromRepo = _repository.GetLoadById(id);
            if(loadModelFromRepo==null)
            {
                return NotFound();
            }
            _mapper.Map(loadUpdateDto, loadModelFromRepo);
            _repository.UpdateLoad(loadModelFromRepo);
            _repository.SaveChanges();
            return NoContent();
        }


        [HttpPost]
        public ActionResult<LoadReadDto> CreateLoad(LoadCreateDto loadCreateDto)
        {
            var loadModel = _mapper.Map<Load>(loadCreateDto);
            _repository.CreateLoad(loadModel);
            _repository.SaveChanges();

            var LoadReadDto = _mapper.Map<LoadReadDto>(loadModel);
            return CreatedAtRoute(nameof(GetLoadById), new {Id = LoadReadDto.Id}, LoadReadDto);
        }


        [HttpGet]
        public ActionResult<IEnumerable<LoadReadDto>> GetAllLoads()
        {
            var loadItems = _repository.GetAllLoads();
            return Ok(_mapper.Map<IEnumerable<LoadReadDto>>(loadItems));
        }

        [HttpGet("{id}",Name="GetLoadById")]
        public ActionResult<Load> GetLoadById(int id)
        {
            var loadItems=_repository.GetLoadById(id);
            if(loadItems==null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<LoadReadDto>(loadItems));
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteLoad(int id)
        {
            var loadModelFromRepo=_repository.GetLoadById(id);
            if(loadModelFromRepo==null)
            {
                return NotFound();
            }
            _repository.DeleteLoad(loadModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        
    }
}