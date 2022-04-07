using Core.Entites.Abstract;

namespace Entities.DTOs
{
    public class StudentDetailDto : IDto
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
