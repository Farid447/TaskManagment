using ApiProject.Core.Repositories;
using FluentValidation;

namespace ApiProject.BL.DTOs.EmployeeDtos;
public class EmployeeCreateDto
{
    public string Ad { get; set; }
}

public class EmployeeCreateDtoValidator : AbstractValidator<EmployeeCreateDto>
{
    readonly IEmployeeRepository _repo;

    public EmployeeCreateDtoValidator(IEmployeeRepository repo)
    {

        //_repo = repo;
    }

}