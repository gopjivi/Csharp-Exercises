using AutoMapper;

namespace LocalGym.Profiles
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            CreateMap<Entities.Member, Models.MemberDto>();
        }
    }
}
