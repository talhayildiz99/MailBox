using MailBox.DtoLayer.Dtos.AppUserDtos;
using MailBox.DtoLayer.Dtos.MailDtos;
using MailBox.EntityLayer.Concrete;
using AutoMapper;


namespace MailBox.BusinessLayer.MappingProfile
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<AppUser, AppUserRegisterDto>().ReverseMap();
            CreateMap<AppUser, AppUserRegisterDto>().ReverseMap();

            CreateMap<Mail, ListMailDto>()
           .ForMember(dest => dest.ReceiverEmail, opt => opt.MapFrom(src => src.Receiver.Email)).ForMember(dest => dest.SenderEmail, opt => opt.MapFrom(src => src.Sender.Email))
           .ReverseMap();
        }
    }
}
