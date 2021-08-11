using AutoMapper;
using TherapyAPI.Dto;
using TherapyAPI.Models;

namespace TherapyAPI.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<AppointmentType, AppointmentTypeDto>().ReverseMap();
            CreateMap<Billing, BillingDto>().ReverseMap();
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Therapist, TherapistDto>().ReverseMap();
            CreateMap<Gender, GenderDto>().ReverseMap();
            CreateMap<CivilStatus, CivilStatusDto>().ReverseMap();
        }
    }
}