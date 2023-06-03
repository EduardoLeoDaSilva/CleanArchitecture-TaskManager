﻿using CleanArchitecture.TaskManager.Application.UseCases.TaskManager.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Application.UseCases.TaskManager
{
    public class CreateProjectHandler : IRequestHandler<CreateProjectCommand>
    {
        public Task Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
