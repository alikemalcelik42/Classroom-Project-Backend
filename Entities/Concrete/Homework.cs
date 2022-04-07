using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class Homework : IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string FileUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
