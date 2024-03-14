using System.Net.Sockets;
using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Repository;

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
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _doctorRepository.GetAllDoctors();
            return Ok(doctors);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneDoctor(int id)
        {
            var animal = await _doctorRepository.GetDoctorById(id);
            if (animal != null)
            {
                return Ok(animal);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PostDoctor(Doctor doctor)
        {
            await _doctorRepository.AddDoctor(doctor);
            return CreatedAtAction(nameof(GetOneDoctor), new { id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDoctor(Doctor doctor, int id)
        {
            var doctorSelected = await _doctorRepository.GetDoctorById(id);
            if (doctorSelected != null)
            {
                doctorSelected.Name = doctor.Name;
                doctorSelected.WorkingTime = doctor.WorkingTime;
                await _doctorRepository.UpdaterDoctor(doctorSelected);
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
           var doctorSelected = await _doctorRepository.GetDoctorById(id);
            if(doctorSelected != null)
            {
                await _doctorRepository.DeleteDoctor(id);
                return NoContent();
            }
            return NotFound();
        }

    }
}
