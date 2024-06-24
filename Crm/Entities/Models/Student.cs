using Crm.Entities.Commons;

namespace Crm.Entities.Models
{
    public class Student : Auditable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime DateOfBirth { get; set; }


    }
}
