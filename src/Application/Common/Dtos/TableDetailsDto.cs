﻿using Domain.Enums;
using Application.Common.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Entities = Domain.Entities;

namespace Application.Common.Dtos
{
    public class TableDetailsDto : IMapFrom<Entities.Table>
    {

        public int TableNumber { get; set; }
        public int ChairsCount { get; set; }

        //public TableStatus Status { get; set; }

        public virtual void Mapping(Profile profile)
        {
            profile.CreateMap<Entities.Table, TableDetailsDto>()
            .ForMember(x => x.TableNumber, x => x.MapFrom(o => o.Id));
        }

    }

    public class ComplexTableDto : TableDetailsDto
    {

        public List<Entities.Reservation> Reservations { get; set; }

        public override void Mapping(Profile profile)
        {
            profile.CreateMap<Entities.Table, ComplexCustomerDto>();
        }

    }

}