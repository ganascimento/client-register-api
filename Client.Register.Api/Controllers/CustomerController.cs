using Client.Register.Domain.Dto.Customer;
using Client.Register.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace Client.Register.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _customerService.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CustomerDtoCreate dto)
    {
        var result = await _customerService.CreateAsync(dto);
        return Ok(dto);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] CustomerDtoUpdate dto)
    {
        var result = await _customerService.UpdateAsync(dto);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _customerService.DeleteAsync(id);
        return Ok(result);
    }
}
