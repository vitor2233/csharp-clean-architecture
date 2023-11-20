using CleanArch.Domain.Model;

namespace CleanArch.Application.Business;

public interface ICustomerBusiness
{
    public List<Customer> GetCustomers();
    public Customer CreateCustomer(CustomerCreate customer);
    public Customer UpdateCustomer(Customer customer);
    public void DeleteCustomer(int id);
}