using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı ve soyadı kısmı boş geçilemez.");
			RuleFor(x => x.WriteMail).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en az 50 karakter girişi yapın.");

		}

	}
}