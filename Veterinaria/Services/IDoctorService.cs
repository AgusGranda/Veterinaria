using Veterinaria.Models;

namespace Veterinaria.Services
{
    public interface IDoctorService
    {
        Task<IResult> GetAllDoctors();
        Task<IResult> GetDoctorById(int id);
        Task<IResult> AddDoctor(Doctor doctor);
        Task<IResult> UpdaterDoctor(Doctor doctor);
        Task<IResult> DeleteDoctor(int id);
    }
}
