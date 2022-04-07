using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        ITeacherDal _teacherDal;

        public TeacherManager(ITeacherDal teacherDal)
        {
            _teacherDal = teacherDal;
        }

        public IResult Add(Teacher teacher)
        {
            _teacherDal.Add(teacher);
            return new SuccessResult(Messages.TeacherAdded);
        }

        public IResult Delete(Teacher teacher)
        {
            _teacherDal.Delete(teacher);
            return new SuccessResult(Messages.TeacherDeleted);
        }

        public IDataResult<List<Teacher>> GetAll()
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll(), Messages.TeachersListed);
        }

        public IDataResult<List<Teacher>> GetAllByLessonId(int lessonId)
        {
            return new SuccessDataResult<List<Teacher>>(_teacherDal.GetAll(t => t.LessonId == lessonId), Messages.TeachersListed);
        }

        public IDataResult<Teacher> GetById(int id)
        {
            return new SuccessDataResult<Teacher>(_teacherDal.Get(t => t.Id == id), Messages.TeachersListed);
        }

        public IDataResult<List<TeacherDetailDto>> GetTeacherDetails()
        {
            return new SuccessDataResult<List<TeacherDetailDto>>(_teacherDal.GetTeacherDetails(), Messages.TeachersListed);
        }

        public IResult Update(Teacher teacher)
        {
            _teacherDal.Update(teacher);
            return new SuccessResult(Messages.TeacherUpdated);
        }
    }
}
