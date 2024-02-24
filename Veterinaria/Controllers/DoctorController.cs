using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var doctors = _doctorRepository.GetAllDoctors();
            return Ok(doctors);
        }


        [HttpGet("{id}")]
        public IActionResult GetOneDoctor(int id)
        {
            var doctor = _doctorRepository.GetDoctorById(id);
            if (doctor != null)
            {
                return Ok(doctor);

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult PostDoctor(Doctor doctor)
        {
            _doctorRepository.AddDoctor(doctor);

            return CreatedAtAction(nameof(GetOneDoctor), new { Id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public IActionResult PutDoctor(Doctor doctor, int id)
        {
            var doctorToEdit = _doctorRepository.GetDoctorById(id);
            if (doctorToEdit != null)
            {
                doctorToEdit.Name = doctor.Name;
                doctorToEdit.WorkingTime = doctor.WorkingTime;
                _doctorRepository.UpdaterDoctor(doctorToEdit);

                return NoContent();
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var doctor = _doctorRepository.GetDoctorById(id);
            if (doctor != null)
            {
                _doctorRepository.DeleteDoctor(id);
                return NoContent();
            }
            return NotFound();
        }

    }
}
