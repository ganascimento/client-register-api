using Client.Register.Domain.Entity;
using Client.Register.Domain.Repository;
using Client.Register.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Client.Register.Infra.Repository;

public class CustomerRepository : Repository<CustomerEntity>, ICustomerRepository
{
    private DbSet<CustomerEntity> _dataset;

    public CustomerRepository(DataContext context) : base(context)
    {
        _dataset = context.Set<CustomerEntity>();
    }

    public async Task<bool> CpfExists(string cpf)
    {
        return await _dataset.AnyAsync(x => x.Cpf == cpf);
    }
}