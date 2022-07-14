using AutoMapper;
using MovieRental.Dtos;
using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRental.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Movie , MovieDto>();
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<GenreDto, Genre>();
            Mapper.CreateMap<Genre, GenreDto>();
            

        }
    }
}