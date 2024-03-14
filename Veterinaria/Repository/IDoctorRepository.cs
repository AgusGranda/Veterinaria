using Veterinaria.Models;

namespace Veterinaria.Repository
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorById(int id);
        Task AddDoctor(Doctor doctor);
        Task UpdaterDoctor(Doctor doctor);
        Task DeleteDoctor(int id);
    }
}
