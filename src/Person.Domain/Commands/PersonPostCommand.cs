using System;
using MediatR;
using Person.Domain.Dtos;
using Person.Domain.Entities;

namespace Person.Domain.Commands
{
    public class PersonPostCommand : IRequest<ServiceResponse<GetPersonDto>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentId { get; set; }
        public DateTime Birthdate { get; set; }
    }
}