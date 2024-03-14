using Microsoft.EntityFrameworkCore;
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


        public async Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            return await _dbContext.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetDoctorById(int id)
        {

            return await _dbContext.Doctors.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Add(doctor);
            await _dbContext.SaveChangesAsync();
        }



        public async Task UpdaterDoctor(Doctor doctor)
        {
            _dbContext.Doctors.Update(doctor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteDoctor(int id)
        {
            var doctor = await _dbContext.Doctors.FirstOrDefaultAsync(p => p.Id == id);
            if (doctor != null)
            {
                 _dbContext.Doctors.Remove(doctor);
                await _dbContext.SaveChangesAsync();
            }
        }


    }
}
