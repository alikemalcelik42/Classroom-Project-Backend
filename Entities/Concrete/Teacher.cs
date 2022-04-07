using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
