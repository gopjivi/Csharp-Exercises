using LocalGym.Data;
using LocalGym.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LocalGym.Services
{
    public class LocalGymRepository : ILocalGymRepository
    {
        private GymDbContext _dbContext;
        public LocalGymRepository(GymDbContext gymDbContext) {
            _dbContext = gymDbContext; 
        }
        public async Task<Member> GetMemberAsync(int id)
        {
            return await _dbContext.Members.Where(c=>c.MemberId==id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            return await _dbContext.Members.ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionsForMemberAsync(int id)
        {
            return await _dbContext.Sessions.Where(c => c.CustomerId == id).ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionsForTrainerAsync(int id)
        {
            return await _dbContext.Sessions.Where(c => c.TrainerId == id).ToListAsync();
        }

        public async Task<Trainer> GetTrainerAsync(int id)
        {
            return await _dbContext.Trainers.Where(c => c.TrainerId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Trainer>> GetTrainersAsync()
        {
            return await _dbContext.Trainers.ToListAsync();
        }
        public void  AddTrainer(Trainer trainer)
        {
             _dbContext.Add(trainer);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _dbContext.SaveChangesAsync()>=0);
        }
    }
}
