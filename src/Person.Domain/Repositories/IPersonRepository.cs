using System.Threading.Tasks;
using Person.Domain.Dtos.Repositories;

namespace Person.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task SavePerson(SavePersonRepositoryDto savePerson);
    }
}
