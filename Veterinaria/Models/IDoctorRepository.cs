namespace Veterinaria.Models
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctors();
        Doctor GetDoctorById(int id);
        void AddDoctor(Doctor doctor);
        void UpdaterDoctor(Doctor doctor);
        void DeleteDoctor(int id);
    }
}
