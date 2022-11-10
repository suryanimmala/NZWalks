using AutoMapper;

namespace NZWalks.API.Models.Profiles
{
    public class Region: Profile
    {
        public Region()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
        }
    }
}
