using System.Threading;
using System.Threading.Tasks;
using Mapster;
using MediatR;
using Person.Domain.Commands;
using Person.Domain.Dtos;
using Person.Domain.Dtos.Repositories;
using Person.Domain.Entities;
using Person.Domain.Repositories;

namespace Person.Domain.Handlers
{
    public class PersonPostHandler : IRequestHandler<PersonPostCommand, ServiceResponse<GetPersonDto>>
    {
        private readonly IPersonRepository _personRepository;

        public PersonPostHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<ServiceResponse<GetPersonDto>> Handle(PersonPostCommand request,
            CancellationToken cancellationToken)
        {
            var serviceResponse = new ServiceResponse<GetPersonDto>();

            await _personRepository.SavePerson(request.Adapt<SavePersonRepositoryDto>());

            serviceResponse.Data = request.Adapt<GetPersonDto>();

            serviceResponse.Message = $"Person: {request.FirstName} has been added successfully.";

            return serviceResponse;
        }
    }
}