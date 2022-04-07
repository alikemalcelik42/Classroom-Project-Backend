using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        IDataResult<List<Teacher>> GetAll();
        IDataResult<List<Teacher>> GetAllByLessonId(int lessonId);
        IDataResult<List<TeacherDetailDto>> GetTeacherDetails();
        IDataResult<Teacher> GetById(int id);
        IResult Add(Teacher teacher);
        IResult Update(Teacher teacher);
        IResult Delete(Teacher teacher);
    }

}
