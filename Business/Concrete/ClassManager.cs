using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ClassManager : IClassService
    {
        IClassDal _classDal;

        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
        }

        public IResult Add(Class @class)
        {
            _classDal.Add(@class);
            return new SuccessResult(Messages.ClassAdded);
        }

        public IResult Delete(Class @class)
        {
            _classDal.Delete(@class);
            return new SuccessResult(Messages.ClassDeleted);
        }

        public IDataResult<List<Class>> GetAll()
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll(), Messages.ClassesListed);
        }

        public IDataResult<Class> GetById(int id)
        {
            return new SuccessDataResult<Class>(_classDal.Get(c => c.Id == id), Messages.ClassesListed);
        }

        public IResult Update(Class @class)
        {
            _classDal.Update(@class);
            return new SuccessResult(Messages.ClassUpdated);
        }
    }
}
