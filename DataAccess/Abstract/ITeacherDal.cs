using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ITeacherDal : IEntityRepository<Teacher>
    {
        List<TeacherDetailDto> GetTeacherDetails();
    }
}
