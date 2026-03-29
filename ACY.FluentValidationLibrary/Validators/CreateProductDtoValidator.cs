using ACY.FluentValidationLibrary.Dtos;
using FluentValidation;

namespace ACY.FluentValidationLibrary.Validators;

public sealed class CreateProductDtoValidator:AbstractValidator<CreateProductDto>
{
    public CreateProductDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Product name is required.");
        RuleFor(x => x.Price).GreaterThan(0).WithMessage("Product price must be greater than zero.");
    }
}
