using Core.Entites.Abstract;

namespace Entities.DTOs
{
    public class HomeworkDetailDto : IDto
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string LessonName { get; set; }
        public string ClassName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string FileUrl { get; set; }
        public DateTime Date { get; set; }
    }
}
