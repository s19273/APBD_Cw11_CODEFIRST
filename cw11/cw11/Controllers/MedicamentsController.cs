using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/medicament")]
    [ApiController]
    public class MedicamentsController : ControllerBase
    {
        public readonly IDbService _service;
        public MedicamentsController(IDbService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetMedicament()
        {
            return Ok(_service.GetDoctors());
        }
        [HttpPost]
        public IActionResult AddNewDoctor(Doctor doctor)
        {
            try
            {
                _service.AddNewDoctor(doctor);
            }catch(Exception exc)
            {
                return BadRequest("bład przy dodawaniu doktora");
            }
            return Ok("dodano doktora");
        }
        [HttpPut]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            try
            {
                _service.modifyDoctor(doctor);
            }
            catch (Exception exc)
            {
                return BadRequest("bład przy modyfikowaniu doktora");
            }
            return Ok("zmodyfikowano doktora o id " + doctor.IdDoctor);
        }

        [HttpPost("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            try
            {
                _service.deleteDoctor(id);
            }
            catch (Exception exc)
            {
                return BadRequest("bład przy usuwaniu doktora");
            }
            return Ok("usunieto doktora o id " + id);
        }
    }
}