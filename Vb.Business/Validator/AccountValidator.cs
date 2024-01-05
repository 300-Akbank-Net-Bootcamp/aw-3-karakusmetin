using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator
{
	public class CreateAccountValidator : AbstractValidator<AccountRequest>
	{
		public CreateAccountValidator()
		{
			RuleFor(x => x.IBAN).NotEmpty().Length(20);
			RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
			
		}
	}
}
