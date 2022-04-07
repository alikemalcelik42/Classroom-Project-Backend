using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{

    public class HomeworkManager : IHomeworkService
    {
        IHomeworkDal _homeworkDal;
        ITeacherService _teacherService;
        IHomeworkFileService _homeworkFileService;

        public HomeworkManager(IHomeworkDal homeworkDal, ITeacherService teacherService, IHomeworkFileService homeworkFileService)
        {
            _homeworkDal = homeworkDal;
            _teacherService = teacherService;
            _homeworkFileService = homeworkFileService;
        }

        public IResult Add(Homework homework, IFormFile file)
        {
            var fileDetail = _homeworkFileService.Add(file);
            homework.FilePath = fileDetail.Data.FilePath;
            homework.FileUrl = fileDetail.Data.FileUrl;

            _homeworkDal.Add(homework);
            return new SuccessResult(Messages.HomeworkAdded);
        }

        public IResult Delete(Homework homework)
        {
            _homeworkFileService.Delete(homework.FilePath);

            _homeworkDal.Delete(homework);
            return new SuccessResult(Messages.HomeworkDeleted);
        }

        public IDataResult<List<Homework>> GetAll()
        {
            return new SuccessDataResult<List<Homework>>(_homeworkDal.GetAll(), Messages.HomeworksListed);
        }

        public IDataResult<List<Homework>> GetAllByClassId(int classId)
        {
            return new SuccessDataResult<List<Homework>>(_homeworkDal.GetAll(h => h.ClassId == classId), Messages.HomeworksListed);
        }

        public IDataResult<List<Homework>> GetAllByLessonId(int lessonId)
        {
            List<Homework> homeworks = new List<Homework>();

            foreach (var h in _homeworkDal.GetAll())
            {
                if (_teacherService.GetById(h.TeacherId).Data.LessonId == lessonId)
                {
                    homeworks.Add(h);
                }
            }

            return new SuccessDataResult<List<Homework>>(homeworks, Messages.HomeworksListed);
        }

        public IDataResult<List<Homework>> GetAllByTeacherId(int teacherId)
        {
            return new SuccessDataResult<List<Homework>>(_homeworkDal.GetAll(h => h.TeacherId == teacherId), Messages.HomeworksListed);
        }

        public IDataResult<Homework> GetById(int id)
        {
            return new SuccessDataResult<Homework>(_homeworkDal.Get(h => h.Id == id), Messages.HomeworksListed);
        }

        public IDataResult<List<HomeworkDetailDto>> GetHomeworkDetails()
        {
            return new SuccessDataResult<List<HomeworkDetailDto>>(_homeworkDal.GetHomeworkDetails(), Messages.HomeworksListed);
        }

        public IResult Update(Homework homework)
        {
            _homeworkDal.Update(homework);
            return new SuccessResult(Messages.HomeworkUpdated);
        }

        public IResult UpdateWithFile(Homework homework, IFormFile file)
        {
            var fileDetail = _homeworkFileService.Update(homework.FilePath, file);
            homework.FilePath = fileDetail.Data.FilePath;
            homework.FileUrl = fileDetail.Data.FileUrl;

            _homeworkDal.Update(homework);
            return new SuccessResult(Messages.HomeworkUpdated);
        }
    }
}
