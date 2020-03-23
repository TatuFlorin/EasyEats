﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Controllers
{
    [Route("EasyApi/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}