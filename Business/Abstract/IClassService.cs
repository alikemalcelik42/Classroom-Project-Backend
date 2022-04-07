using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IClassService
    {
        IDataResult<List<Class>> GetAll();
        IDataResult<Class> GetById(int id);
        IResult Add(Class @class);
        IResult Update(Class @class);
        IResult Delete(Class @class);
    }

}
