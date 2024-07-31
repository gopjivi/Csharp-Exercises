using LocalGym.Entities;

namespace LocalGym.Services
{
    public interface ILocalGymRepository
    {
         Task<IEnumerable<Member>> GetMembersAsync();
         Task<Member> GetMemberAsync(int id);
         Task<IEnumerable<Trainer>> GetTrainersAsync();
         Task<Trainer> GetTrainerAsync(int id);

         Task<IEnumerable<Session>> GetSessionsForTrainerAsync(int id);
         Task<IEnumerable<Session>>  GetSessionsForMemberAsync(int id);

         void  AddTrainer (Trainer trainer);
        Task<bool> SaveChangesAsync(); 

    }
}
