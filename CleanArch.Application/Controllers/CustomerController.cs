
using CleanArch.Application.Business;
using CleanArch.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerBusiness _business;
    public CustomerController(ICustomerBusiness business)
    {
        _business = business;
    }

    [HttpGet(Name = "GetCustomers")]
    public List<Customer> GetCustomers()
    {
        return _business.GetCustomers();
    }

    [HttpPost(Name = "CreateCustomer")]
    public Customer CreateCustomer([FromBody] CustomerCreate customer)
    {
        return _business.CreateCustomer(customer);
    }

    [HttpPut(Name = "UpdateCustomer")]
    public Customer UpdateCustomer([FromBody] Customer customer)
    {
        return _business.UpdateCustomer(customer);
    }

    [HttpDelete(Name = "DeleteCustomer/{id}")]
    public ActionResult DeleteCustomer(int id)
    {
        _business.DeleteCustomer(id);
        return Ok();
    }

}