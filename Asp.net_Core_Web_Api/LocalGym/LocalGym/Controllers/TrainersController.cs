using AutoMapper;
using LocalGym.Entities;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    [Route("api/[controller]")]
   [Authorize]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        private ILocalGymRepository _localGymRepository;
        private IMapper _mapper;
        public TrainersController(ILocalGymRepository localGymRepository, IMapper mapper)
        {
            _localGymRepository = localGymRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainerDto>>> GetAllTrainers()
        {
            var trainers = await _localGymRepository.GetTrainersAsync();

            return Ok(_mapper.Map<IEnumerable<TrainerDto>>(trainers));
        }
        /// <summary>
        /// get trainer by ide
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return train by id</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TrainerDto>> GetTrainerByID(int id)
        {
            var trainer = await _localGymRepository.GetTrainerAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<TrainerDto>(trainer));
        }

        [HttpPost]
        public async Task<ActionResult> CreateTrainer([FromBody] TrainerDto trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var trainerEntity = _mapper.Map<Trainer>(trainer);
            _localGymRepository.AddTrainer(trainerEntity);



            if (await _localGymRepository.SaveChangesAsync())
            {
                var trainerToReturn = _mapper.Map<TrainerDto>(trainerEntity);
                return CreatedAtAction(nameof(GetTrainerByID), new { id = trainerToReturn.TrainerId }, trainerToReturn);
            }

            return BadRequest("Could not add the trainer.");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTrainer(int id,[FromBody] TrainerDto trainer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var oldTrainer = await _localGymRepository.GetTrainerAsync(id);
            if (trainer == null)
            {
                return NotFound();
            }
            _mapper.Map(trainer, oldTrainer);


            // Save the changes in the repository
            if (await _localGymRepository.SaveChangesAsync())
            {
                return NoContent(); // 204 No Content
            }


            return StatusCode(500, "An error occurred while updating the trainer.");
        }
    }
}
