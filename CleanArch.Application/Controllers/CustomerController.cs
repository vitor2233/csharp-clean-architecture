
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

}