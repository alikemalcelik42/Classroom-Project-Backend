using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{

    public interface IHomeworkService
    {
        IDataResult<List<Homework>> GetAll();
        IDataResult<List<Homework>> GetAllByTeacherId(int teacherId);
        IDataResult<List<Homework>> GetAllByClassId(int classId);
        IDataResult<List<Homework>> GetAllByLessonId(int lessonId);
        IDataResult<List<HomeworkDetailDto>> GetHomeworkDetails();
        IDataResult<Homework> GetById(int id);
        IResult Add(Homework homework, IFormFile file);
        IResult Update(Homework homework);
        IResult UpdateWithFile(Homework homework, IFormFile file);
        IResult Delete(Homework homework);
    }

}
