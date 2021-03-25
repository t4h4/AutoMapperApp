using AutoMapper;
using FluentValidationApp.DTOs;
using FluentValidationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentValidationApp.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            // kaynak ve hedef
            CreateMap<Customer, CustomerDto>().ReverseMap(); //reverse map ile tam terside gerçekleşmeye imkan verir. daha az kod yazıyoruz. 
        }
    }
}
