﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.useCases.Authors.Commands
{
    public class DeleteAuthorCommand : IRequest
    {
        public int Id { get; set; }
    }
}