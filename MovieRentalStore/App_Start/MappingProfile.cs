﻿using AutoMapper;
using MovieRentalStore.Dtos;
using MovieRentalStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalStore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}