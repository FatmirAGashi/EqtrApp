using EqtrApp.Domain;
using EqtrApp.Services.Abtractions;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using qtrApp.Api.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EqtrApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly ICitizenService _citizenService;
        public CitizensController(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] CitizensOutputModel model)
        {
            try
            {
                var domainModel = model.Adapt<Citizens>();
                _citizenService.Add(domainModel);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPost]
        [Route("addMany")]
        public IActionResult Add(IEnumerable<CitizensOutputModel> citizensModelOutputs)
        {
            try
            {
                var domainModels = citizensModelOutputs.Adapt<IEnumerable<Citizens>>();
                _citizenService.Add(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _citizenService.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet()]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = _citizenService.Get(id);
                var outputModel = model.Adapt<CitizensOutputModel>();

                return Ok(outputModel);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAll()
        {
            try
            {
                var models = _citizenService.GetAll();
                var outputModels = models.Adapt<IEnumerable<CitizensOutputModel>>();

                return Ok(outputModels);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult Update([FromBody] CitizensOutputModel model)
        {
            try
            {
                var domainModel = model.Adapt<Citizens>();
                _citizenService.Update(domainModel);

                return Ok(domainModel);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpPut]
        [Route("updateMany")]
        public IActionResult UpdateMany([FromBody] IEnumerable<CitizensOutputModel> models)
        {
            try
            {
                var domainModels = models.Adapt<IEnumerable<Citizens>>();
                _citizenService.Update(domainModels);

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}
    
