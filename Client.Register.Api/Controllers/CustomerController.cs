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

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var result = await _customerService.GetByIdAsync(id);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var result = await _customerService.GetAllAsync();
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CustomerDtoCreate dto)
    {
        try
        {
            var result = await _customerService.CreateAsync(dto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] CustomerDtoUpdate dto)
    {
        try
        {
            var result = await _customerService.UpdateAsync(dto);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var result = await _customerService.DeleteAsync(id);
            return Ok(result);
        }
        catch
        {
            return BadRequest();
        }
    }
}
