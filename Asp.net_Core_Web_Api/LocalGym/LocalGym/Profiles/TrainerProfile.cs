using AutoMapper;

namespace LocalGym.Profiles
{
    public class TrainerProfile:Profile
    {
        public TrainerProfile()
        {
            CreateMap<Entities.Trainer,Models.TrainerDto>().ReverseMap();
           
        }
    }
}
