using AutoMapper;
using Jitu_udemy.Responses;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;
using Jitu_Udemy.Responses;

namespace Jitu_Udemy.Profiles{
    public class JituProfiles:Profile{
        public JituProfiles()
        {
            CreateMap<AddUser, User>().ReverseMap();
            CreateMap<UserResponse, User>().ReverseMap();

            //  Instructor
            CreateMap<AddUser, Instructor>().ReverseMap();
            CreateMap<UserResponse, Instructor>().ReverseMap();

            //Courses
            CreateMap<AddCourse, Course>().ReverseMap();
            CreateMap<UpdateCourse, Course>().ReverseMap();
            CreateMap<CourseResponse, Course>().ReverseMap();
        }
    }
}