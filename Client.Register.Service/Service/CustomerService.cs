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

    public async Task<CustomerDto> GetByIdAsync(int id)
    {
        var customer = await _customerRepository.SelectAsync(id);
        return _mapper.Map<CustomerDto>(customer);
    }

    public async Task<IEnumerable<CustumerDtoGetAll>> GetAllAsync()
    {
        var customers = await _customerRepository.SelectAsync();
        return customers.Select(customer => _mapper.Map<CustumerDtoGetAll>(customer));
    }

    public async Task<CustomerDto> CreateAsync(CustomerDtoCreate dto)
    {
        await CpfExists(dto.Cpf!);
        var customer = _mapper.Map<CustomerEntity>(dto);
        customer = await _customerRepository.InsertAsync(customer);

        return _mapper.Map<CustomerDto>(customer);
    }

    public async Task<CustomerDto> UpdateAsync(CustomerDtoUpdate dto)
    {
        var oldCustomer = await _customerRepository.SelectAsync(dto.Id);
        if (oldCustomer != null && oldCustomer.Cpf != dto.Cpf)
            await CpfExists(dto.Cpf!);
        var customer = _mapper.Map<CustomerEntity>(dto);
        customer = await _customerRepository.UpdateAsync(customer);

        return _mapper.Map<CustomerDto>(customer);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        await _customerRepository.DeleteAsync(id);
        return true;
    }

    private async Task CpfExists(string cpf)
    {
        if (await _customerRepository.CpfExists(cpf))
        {
            throw new Exception("CPF já existe");
        }
    }
}