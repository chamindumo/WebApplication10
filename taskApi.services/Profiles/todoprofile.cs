using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskApi.services.Models;
using WebApplication10.Models;
using WebApplication10.Service;

namespace WebApplication10.services.Profiles
{
    public class todoprofile : Profile
    {
        public todoprofile()
        {
            CreateMap<todo, Tododto>();
            CreateMap<taskApi.services.Todos.Createtodo, Tododto>();
            CreateMap<updatetodo,todo>();


        }
    }
}
