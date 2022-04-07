using Core.Utilities.Results.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IHomeworkFileService
    {
        IDataResult<FileDetailDto> Add(IFormFile file);
        IResult Delete(string path);
        IDataResult<FileDetailDto> Update(string oldFilePath, IFormFile file);
    }
}
