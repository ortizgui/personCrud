using System;

namespace Person.Domain.Commands
{
    public class PersonPutCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentId { get; set; }
        public DateTime Birthdate { get; set; }
    }
}