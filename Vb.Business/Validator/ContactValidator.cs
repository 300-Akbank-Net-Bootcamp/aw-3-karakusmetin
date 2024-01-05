using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator
{
	public class CreateContactValidator : AbstractValidator<ContactRequest>
	{
		public CreateContactValidator()
		{
			RuleFor(x => x.ContactType).NotEmpty();
			RuleFor(x => x.Information).NotEmpty().MaximumLength(160);
			
		}
	}
}
