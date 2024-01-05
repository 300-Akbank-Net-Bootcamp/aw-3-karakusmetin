using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator
{
	public class CreateAccountTransactionValidator : AbstractValidator<AccountTransactionRequest>
	{
		public CreateAccountTransactionValidator()
		{
			RuleFor(x => x.TransferType).NotEmpty().MinimumLength(20);


		}
	}
}
