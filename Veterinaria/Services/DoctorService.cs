using Veterinaria.Models;
using Veterinaria.Repository;

namespace Veterinaria.Services
{
    public class DoctorService : IDoctorService
    {

        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public Task<IResult> AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> GetDoctorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdaterDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
