using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfHomeworkDal : EfEntityRepositoryBase<Homework, ClassroomContext>, IHomeworkDal
    {
        public List<HomeworkDetailDto> GetHomeworkDetails()
        {
            using (var context = new ClassroomContext())
            {
                var result = from homework in context.Homeworks
                             join teacher in context.Teachers
                             on homework.TeacherId equals teacher.Id
                             join @class in context.Classes
                             on homework.ClassId equals @class.Id
                             join lesson in context.Lessons
                             on teacher.LessonId equals lesson.Id
                             select new HomeworkDetailDto
                             {
                                 Id = homework.Id,
                                 TeacherName = teacher.FirstName,
                                 LessonName = lesson.Name,
                                 ClassName = @class.Name,
                                 Name = homework.Name,
                                 Description = homework.Description,
                                 FilePath = homework.FilePath,
                                 FileUrl = homework.FileUrl,
                                 Date = homework.Date
                             };
                return result.ToList();

            }
        }
    }
}
