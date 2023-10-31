
using CleanArch.Domain.Model;
using CleanArch.Infra.Repository;

namespace CleanArch.Application.Business;

public class CustomerBusiness : ICustomerBusiness
{
    private readonly ICustomerRepository _repository;
    public CustomerBusiness(ICustomerRepository repository)
    {
        _repository = repository;
    }
    public List<Customer> GetCustomers()
    {
        return _repository.GetCustomers();
    }
}