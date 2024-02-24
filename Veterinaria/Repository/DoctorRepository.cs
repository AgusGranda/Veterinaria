using Veterinaria.DataAccess;
using Veterinaria.Models;

namespace Veterinaria.Repository
{
    public class DoctorRepository : IDoctorRepository
    {

        private readonly MyDbContext _dbContext;

        public DoctorRepository(MyDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }




        public IEnumerable<Doctor> GetAllDoctors()
        {
            return _dbContext.Doctors.ToList();
        }

        public Doctor GetDoctorById(int id)
        {

            return _dbContext.Doctors.FirstOrDefault(p => p.Id == id);
        }

        public void AddDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            _dbContext.SaveChanges();
        }



        public void UpdaterDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Update(doctor);
            _dbContext.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _dbContext.Doctors.FirstOrDefault(p => p.Id == id);
            if (doctor != null)
            {
                _dbContext.Doctors.Remove(doctor);
                _dbContext.SaveChanges();
            }
        }


    }
}
