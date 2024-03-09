using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Repository;
using Veterinaria.Services;

namespace Veterinaria.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            throw new NotImplementedException();
        }


        [HttpGet("{id}")]
        public IActionResult GetOneDoctor(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult PostDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult PutDoctor(Doctor doctor, int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            throw new NotImplementedException();

        }

    }
}
