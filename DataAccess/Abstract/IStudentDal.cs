using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
        List<StudentDetailDto> GetStudentDetails();
    }
}
