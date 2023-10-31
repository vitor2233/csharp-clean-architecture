using CleanArch.Domain.Model;

namespace CleanArch.Application.Business;

public interface ICustomerBusiness
{
    public List<Customer> GetCustomers();
}