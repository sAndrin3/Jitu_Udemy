using AutoMapper;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;
using Jitu_Udemy.Responses;
using Jitu_Udemy.Services.Iservices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Jitu_Udemy.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public  class InstructorController : ControllerBase{
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;

        public InstructorController(IMapper mapper, IInstructorService service)
        {
            _mapper = mapper;
            _instructorService = service;
        }

        [HttpPost]
        public async Task <ActionResult<UserSuccess>> AddInstructor(AddUser newUser){
            // mapping
            var user = _mapper.Map<Instructor>(newUser);
            var res = await _instructorService.AddInstructorAsync(user);
            return CreatedAtAction(nameof(AddInstructor), new UserSuccess(201, res));
        }

        [HttpGet]
        public async Task <ActionResult<IEnumerable<UserResponse>>> GetAllInstructors(){
            var response = await _instructorService.GetAllInstructorsAsync();
            var instructors = _mapper.Map<IEnumerable<UserResponse>>(response);
            return Ok(instructors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetInstructor(Guid id)
        {
            var response = await _instructorService.GetUserByIdAsync(id);
            if(response == null){
                return NotFound(new UserSuccess(404, "Instructor not found"));
            }
            var instructor = _mapper.Map<UserResponse>(response);
            return Ok(instructor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserResponse>> updateInstructor(Guid id, AddUser updatedInstructor)
        {
            var response = await _instructorService.GetUserByIdAsync(id);
            if(response == null){
                return NotFound(new UserSuccess(404, "Instructor not found"));
            }
            // updated
            var updated = _mapper.Map(updatedInstructor, response);
            var res = await _instructorService.UpdateInstructorAsync(updated);
            return Ok(new UserSuccess(204, res));
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<UserResponse>> DeleteInstructor(Guid id, AddUser updatedInstructor)
        {
            var response = await _instructorService.GetUserByIdAsync(id);
            if(response == null){
                return NotFound(new UserSuccess(404, "Instructor not found"));
            }
            // deleted
            var res = await _instructorService.DeleteInstructorAsync(response);
            return Ok(new UserSuccess(204, res));
        }
    }
}