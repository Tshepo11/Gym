using System;
using GymMan.DTO;
using Volo.Abp.Application.Services;

namespace GymMan.Service
{
    public interface IEmployeeAppService :
         ICrudAppService< //Defines CRUD methods
            EmployeeDto, //Used to show books
            Guid, //Primary key of the book entity
            Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateEmployeeDto> //Used to create/update a book
    {

    }
    
}
