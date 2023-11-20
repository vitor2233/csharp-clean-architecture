
using AutoMapper;
using CleanArch.Domain.Model;
using CleanArch.Infra.Entity;

namespace CleanArch.Infra.Repository;

public class CustomerRepository : ICustomerRepository
{
    private readonly CleanArchContext _context;
    private readonly IMapper _mapper;
    public CustomerRepository(CleanArchContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    private CustomerEntity GetCustomerEntity(int id)
    {
        var customer = _context.Customer.FirstOrDefault(c => c.Id == id);
        return customer;
    }

    public List<Customer> GetCustomers()
    {
        var customers = _context.Customer.OrderByDescending(c => c.Id).ToList();
        return _mapper.Map<List<Customer>>(customers);
    }

    public Customer CreateCustomer(CustomerCreate customer)
    {
        var customerEntity = _mapper.Map<CustomerEntity>(customer);
        _context.Customer.Add(customerEntity);
        _context.SaveChanges();
        return _mapper.Map<Customer>(customerEntity);
    }

    public Customer UpdateCustomer(Customer customer)
    {
        var customerEntity = _mapper.Map<CustomerEntity>(customer);
        _context.Customer.Update(customerEntity);
        _context.SaveChanges();
        return _mapper.Map<Customer>(customerEntity);
    }

    public void DeleteCustomer(int id)
    {
        var customerToDelete = GetCustomerEntity(id);
        _context.Customer.Remove(customerToDelete);
        _context.SaveChanges();
    }
}