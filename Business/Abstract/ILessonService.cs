using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ILessonService
    {
        IDataResult<List<Lesson>> GetAll();
        IDataResult<Lesson> GetById(int id);
        IResult Add(Lesson lesson);
        IResult Update(Lesson lesson);
        IResult Delete(Lesson lesson);
    }

}
