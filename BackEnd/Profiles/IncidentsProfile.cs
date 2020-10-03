using AutoMapper;
using BackEnd.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Profiles
{
    public class IncidentsProfile : Profile
    {
        public IncidentsProfile()
        {
            CreateMap<IncidentsProfile, IncidentReadDTO>();
        }
    }
}
