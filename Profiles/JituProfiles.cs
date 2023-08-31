using AutoMapper;
using Jitu_Udemy.Entities;
using Jitu_Udemy.Requests;
using Jitu_Udemy.Responses;

namespace Jitu_Udemy.Profiles{
    public class JituProfiles:Profile{
        public JituProfiles()
        {
            CreateMap<AddUser, User>().ReverseMap();
             CreateMap<UserResponse, User>().ReverseMap();
        }
    }
}