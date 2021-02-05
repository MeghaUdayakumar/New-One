using System.Collections.Generic;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using WebsiteAPI.Data;
using WebsiteAPI.Dtos;
using WebsiteAPI.Models;

namespace WebsiteAPI.Controllers
{
    //api/Outlet
    [Route("api/[Controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class OutletController : ControllerBase
    {
        private readonly IOutletRepo _repository;
        private readonly IMapper _mapper ;

       // creating the repository

        public OutletController(IOutletRepo repository , IMapper mapper )
        {
         _repository = repository;  
        _mapper = mapper;
         
        }
        //private readonly MockOutletRepo _repository = new MockOutletRepo();
        //GET api/outlet
        [HttpGet]
        public ActionResult <IEnumerable<OutletReadDtos>> GetAllOutlets()
        {
            
            var OutletItems = _repository.GetAllOutlets();

            return Ok(_mapper.Map<IEnumerable<OutletReadDtos>>(OutletItems));
        }

        //GET api/outlet/id
        [HttpGet("{id}" , Name="GetOutletById")]
        public ActionResult <OutletReadDtos> GetOutletById(int id)
        {
            //validation check
          var OutletItems = _repository.GetOutletById(id);
          
          if(OutletItems !=null)
          {
              return Ok(_mapper.Map<OutletReadDtos>(OutletItems));
          }
          return NotFound();  
        }

        //POST api/outlet

        [HttpPost]
        public ActionResult<OutletReadDtos> CreateOutlet(OutletCreateDtos outletCreateDtos)
        {
            //mapping the outlet
            var OutletModel= _mapper.Map<Outlet>(outletCreateDtos);
            _repository.CreateOutlet(OutletModel);
            _repository.SaveChanges();

            var outletReadDto = _mapper.Map<OutletReadDtos>(OutletModel);

            // generate the URL 

            return CreatedAtRoute(nameof(GetOutletById), new {Id = outletReadDto.id }, outletReadDto);

            //return Ok(outletReadDto);
        }

        //PUT api/outlet/{id}
        [HttpPut("{id}")]

        public ActionResult UpdateOutlet(int id, OutletUpdateDtos outletUpdateDto)
        {
            //validation check
            var outletModelFromRepo = _repository.GetOutletById(id);
            if(outletModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(outletUpdateDto, outletModelFromRepo);

            _repository.UpdateOutlet(outletModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

        //DELETE /api/Outlet
        [HttpDelete("{id}")]
        public ActionResult DeleteOutlet(int id)
        {
            //validation check
            var outletModelFromRepo = _repository.GetOutletById(id);
            if(outletModelFromRepo == null)
            {
                return NotFound();
            }
            

            _repository.DeleteOutlet(outletModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }


        
        





    }

}