using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
