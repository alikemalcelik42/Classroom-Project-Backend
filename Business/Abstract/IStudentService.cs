using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<List<Student>> GetAllByClassId(int classId);
        IDataResult<List<StudentDetailDto>> GetStudentDetails();
        IDataResult<Student> GetById(int id);
        IResult Add(Student student);
        IResult Update(Student student);
        IResult Delete(Student student);
    }

}
