using ACY.FluentValidationLibrary.Dtos;
using ACY.FluentValidationLibrary.Validators;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace ACY.FluentValidationLibrary.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public IActionResult Create(CreateProductDto request)
    {
        CreateProductDtoValidator validator = new();
        ValidationResult validationResult = validator.Validate(request);
        if (!validationResult.IsValid)
        {
            var messages = validationResult.Errors;
            return BadRequest(messages);
        }

        return Ok(new {Message="Create product is succesfull"});
    }

}
