using CleanArch.Domain.Model;

namespace CleanArch.Infra.Repository;

public interface ICustomerRepository
{
    public List<Customer> GetCustomers();
}