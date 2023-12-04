﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidatior:AbstractValidator<Blog>
    {
        public BlogValidatior()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsin.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsin.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog başlığına 4 karakterden fazla veri girişi yapın.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Blog başlığına 150 karakterden az veri girişi yapın.");

        }
    }
}