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
            throw new NotImplementedException();
        }

        public Doctor GetDoctorById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

                   

        public void UpdaterDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }


    }
}
