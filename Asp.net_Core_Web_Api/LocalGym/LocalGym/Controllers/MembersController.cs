using AutoMapper;
using LocalGym.Models;
using LocalGym.Profiles;
using LocalGym.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace LocalGym.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private ILocalGymRepository _localGymRepository;
        private IMapper _mapper;
        public MembersController(ILocalGymRepository localGymRepository, IMapper mapper)
        {
            _localGymRepository = localGymRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetAllMembers()
        {
            var members = await _localGymRepository.GetMembersAsync();

            return Ok(_mapper.Map<IEnumerable<MemberDto>>(members));
        }
        /// <summary>
        /// get the member by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return the member details by id</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDto>> GetMemberByID(int id)
        {
            var members = await _localGymRepository.GetMemberAsync(id);
            if(members==null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MemberDto>(members));
        }
    }
}