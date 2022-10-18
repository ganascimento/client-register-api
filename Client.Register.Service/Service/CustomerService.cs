using AutoMapper;
using Client.Register.Domain.Dto.Customer;
using Client.Register.Domain.Entity;
using Client.Register.Domain.Repository;
using Client.Register.Domain.Service;

namespace Client.Register.Service.Service;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        var customers = await _customerRepository.SelectAsync();
        return customers.Select(customer => _mapper.Map<CustomerDto>(customer));
    }

    public async Task<CustomerDto> CreateAsync(CustomerDtoCreate dto)
    {
        var customer = _mapper.Map<CustomerEntity>(dto);
        customer = await _customerRepository.InsertAsync(customer);

        return _mapper.Map<CustomerDto>(customer);
    }

    public async Task<CustomerDto> UpdateAsync(CustomerDtoUpdate dto)
    {
        var customer = _mapper.Map<CustomerEntity>(dto);
        customer = await _customerRepository.UpdateAsync(customer);

        return _mapper.Map<CustomerDto>(customer);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _customerRepository.DeleteAsync(id);
        return true;
    }
}