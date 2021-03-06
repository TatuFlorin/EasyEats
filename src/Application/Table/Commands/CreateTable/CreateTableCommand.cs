﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domain.Enums;
using Application.Common.Interfaces;
using MediatR;
using Entities = Domain.Entities;

namespace Application.Table.Commands.CreateTable
{
    public class CreateTableCommand : IRequest
    {
        public int ChairsCount { get; set; }
        public TableStatus Status { get; set; }
    }

    public class CreateTableHandler : IRequestHandler<CreateTableCommand>
    {
        private readonly IEasyEatsDbContext context;
        private readonly IMediator mediator;

        public CreateTableHandler(IEasyEatsDbContext context
            ,IMediator mediator)
        {
            this.context = context;
            this.mediator = mediator;
        }

        public async Task<Unit> Handle(CreateTableCommand request, CancellationToken cancellationToken)
        {
            await context.Tables.AddAsync(new Entities.Table(
                tableStatus: request.Status
                ,chairsCount: request.ChairsCount));

            await context.SaveChangesAsync(cancellationToken);

            await mediator.Publish(new TableCreated());

            return Unit.Value;

        }
    }
}
