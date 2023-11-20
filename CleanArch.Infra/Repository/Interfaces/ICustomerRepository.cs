using CleanArch.Domain.Model;

namespace CleanArch.Infra.Repository;

public interface ICustomerRepository
{
    public List<Customer> GetCustomers();
    public Customer CreateCustomer(CustomerCreate customer);
    public Customer UpdateCustomer(Customer customer);
    public void DeleteCustomer(int id);
}