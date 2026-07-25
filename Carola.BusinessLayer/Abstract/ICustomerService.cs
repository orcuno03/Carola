using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carola.DtoLayer.Dtos.CustomerDtos;

namespace Carola.BusinessLayer.Abstract
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(int id);
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(int id);
    }
}
