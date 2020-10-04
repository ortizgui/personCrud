using System;

namespace Person.Domain.Dtos.Repositories
{
    public class SavePersonRepositoryDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentId { get; set; }
        public DateTime Birthdate { get; set; }
    }
}