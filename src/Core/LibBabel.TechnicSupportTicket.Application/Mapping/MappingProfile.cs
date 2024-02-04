using AutoMapper;
using LibBabel.TechnicSupportTicket.Common.Models.Queries;
using LibBabel.TechnicSupportTicket.Common.Models.Requests;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace LibBabel.TechnicSupportTicket.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Domain.Models.Parameter, CreateParameterCommand>()
            .ReverseMap();

        CreateMap<Domain.Models.Parameter, UpdateParameterCommand>()
            .ReverseMap();

        CreateMap<Domain.Models.Parameter, GetParametersViewModel>()
            .ReverseMap();

        CreateMap<Domain.Models.Parameter, GetParametersByTableIdViewModel>()
            .ReverseMap();

        CreateMap<Domain.Models.Parameter, GetParametersByIdViewModel>()
            .ReverseMap();
    }
}
