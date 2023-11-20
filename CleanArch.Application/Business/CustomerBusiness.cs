
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

    public Customer CreateCustomer(CustomerCreate customer)
    {
        return _repository.CreateCustomer(customer);
    }

    public Customer UpdateCustomer(Customer customer)
    {
        return _repository.UpdateCustomer(customer);
    }

    public void DeleteCustomer(int id)
    {
        _repository.DeleteCustomer(id);
    }
    
}