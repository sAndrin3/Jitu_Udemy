using AutoMapper;
using Jitu_udemy.Responses;
using Jitu_Udemy.Data;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;
using Jitu_Udemy.Responses;
using Jitu_Udemy.Services.Iservices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Jitu_udemy.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class CourseController : ControllerBase {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public CourseController(IMapper mapper, ICourseService service)
        {
            _mapper = mapper;
            _courseService = service;
        }

         [HttpPost]
        public async Task<ActionResult<UserSuccess>> AddCourse(AddCourse newCourse){
            try {
                var user = _mapper.Map<Course>(newCourse);
                var res = await _courseService.AddCourseAsync(user);
                return CreatedAtAction(nameof(AddCourse), new UserSuccess(201, res));
            }catch(Exception ex){
                return BadRequest(new UserSuccess(400, ex.Message));
            }
            
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseResponse>>> GetAllCourses(){
            var response = await _courseService.GetAllCoursesAsync();
            var courses = _mapper.Map<IEnumerable<CourseResponse>>(response);
            return Ok(courses);

        }

         [HttpGet("{id}")]
        public async Task<ActionResult<CourseResponse>> GetCourse(Guid id){
            var response = await _courseService.GetCourseByIdAsync(id);
            if(response == null){
                return NotFound(new UserSuccess(404, "Course Does Not Exist"));
            }
            var course = _mapper.Map<CourseResponse>(response);
            return Ok(course);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CourseSuccess>> UpdateCourse(Guid id, AddCourse UpdatedCourse)
        {
            var response = await _courseService.GetCourseByIdAsync(id);
            if (response == null)
            {
                return NotFound(new UserSuccess(404, "Course Not Found"));
            }
            //update
            var updated = _mapper.Map(UpdatedCourse, response);
            var res = await _courseService.UpdateCourseAsync(updated);
            return Ok(new UserSuccess(204, res));

        }

         [HttpDelete("{id}")]
        public async Task<ActionResult<CourseSuccess>> DeleteCourse(Guid id)
        {
            var response = await _courseService.GetCourseByIdAsync(id);
            if (response == null)
            {
                return NotFound(new UserSuccess(404, "User Does Not Exist"));
            }
            //delete
           
            var res = await _courseService.DeleteCourseAsync(response);
            return Ok(new UserSuccess(204, res));

        }
    }

    public class CourseSuccess
    {
    }

    public class CoursesResponse
    {
    }
}