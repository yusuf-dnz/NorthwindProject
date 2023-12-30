using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        

        
        public ProductValidator() {

            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p=>p.CategoryId==1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
            //RuleFor(p => p.CategoryId).Must(LessThanProductCount).WithMessage("Bir kategoride maksimum 10 ürün olmalı.");
        }

        //private bool LessThanProductCount(IProductDal productDal,int arg)
        //{
        //    _productDal = productDal;
        //    var result = _productDal.GetAll(p => p[arg] == );
        //}

        private bool StartWithA(String arg)
        {
            return arg.StartsWith("A");
        }
    }
}
