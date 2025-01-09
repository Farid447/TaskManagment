using AutoMapper;
using ApiProject.BL.DTOs.EmployeeDtos;
using ApiProject.Core.Entities;

namespace ApiProject.BL.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<EmployeeCreateDto, Employee>();
    }
}
