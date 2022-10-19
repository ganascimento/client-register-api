using Client.Register.Domain.Entity;

namespace Client.Register.Domain.Repository;

public interface ICustomerRepository : IRepository<CustomerEntity>
{
    Task<bool> CpfExists(string cpf);
}