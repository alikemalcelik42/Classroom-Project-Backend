using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStudentDal : EfEntityRepositoryBase<Student, ClassroomContext>, IStudentDal
    {
        public List<StudentDetailDto> GetStudentDetails()
        {
            using (var context = new ClassroomContext())
            {
                var result = from student in context.Students
                             join @class in context.Classes
                             on student.ClassId equals @class.Id
                             select new StudentDetailDto
                             {
                                 Id = student.Id,
                                 ClassName = @class.Name,
                                 FirstName = student.FirstName,
                                 LastName = student.LastName,
                                 NationalNumber = student.NationalNumber,
                                 PhoneNumber = student.PhoneNumber
                             };
                return result.ToList();

            }
        }
    }
}
