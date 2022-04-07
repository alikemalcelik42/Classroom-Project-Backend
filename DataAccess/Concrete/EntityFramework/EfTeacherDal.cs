using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTeacherDal : EfEntityRepositoryBase<Teacher, ClassroomContext>, ITeacherDal
    {
        public List<TeacherDetailDto> GetTeacherDetails()
        {
            using (var context = new ClassroomContext())
            {
                var result = from teacher in context.Teachers
                             join lesson in context.Lessons
                             on teacher.LessonId equals lesson.Id
                             select new TeacherDetailDto
                             {
                                 Id = teacher.Id,
                                 LessonName = lesson.Name,
                                 FirstName = teacher.FirstName,
                                 LastName = teacher.LastName,
                                 NationalNumber = teacher.NationalNumber,
                                 PhoneNumber = teacher.PhoneNumber
                             };
                return result.ToList();

            }
        }
    }
}
