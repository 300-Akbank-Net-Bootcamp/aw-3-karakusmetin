using FluentValidation;
using Vb.Schema;

namespace Vb.Business.Validator
{
	public class EftTransactionValidator : AbstractValidator<EftTransactionRequest>
	{
		public EftTransactionValidator()
		{
			RuleFor(x => x.Amount).NotEmpty();
		

		}
	}
}
