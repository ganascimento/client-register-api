using Client.Register.Domain.Dto.Customer;

namespace Client.Register.Domain.Service;

public interface ICustomerService
{
    Task<CustomerDto> GetByIdAsync(int id);
    Task<IEnumerable<CustumerDtoGetAll>> GetAllAsync();
    Task<CustomerDto> CreateAsync(CustomerDtoCreate dto);
    Task<CustomerDto> UpdateAsync(CustomerDtoUpdate dto);
    Task<bool> DeleteAsync(int id);
}