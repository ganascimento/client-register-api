using Client.Register.Domain.Entity;
using Client.Register.Domain.Repository;
using Client.Register.Infra.Context;

namespace Client.Register.Infra.Repository;

public class CustomerRepository : Repository<CustomerEntity>, ICustomerRepository
{
    public CustomerRepository(DataContext context) : base(context) { }
}