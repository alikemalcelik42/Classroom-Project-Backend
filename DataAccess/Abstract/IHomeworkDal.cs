using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IHomeworkDal : IEntityRepository<Homework>
    {
        List<HomeworkDetailDto> GetHomeworkDetails();
    }
}
