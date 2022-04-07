using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class HomeworkFileManager : IHomeworkFileService
    {
        public readonly string root = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "HomeworkFiles");
        public readonly string url = "https://localhost:9999";

        public IDataResult<FileDetailDto> Add(IFormFile file)
        {
            string fileName = Path.GetFileName(file.FileName);
            string guid = Guid.NewGuid().ToString();
            string fileExtension = Path.GetExtension(fileName);
            string newFileName = guid + fileExtension;

            string filePath = Path.Combine(root, newFileName);
            string fileUrl = $@"{url}/HomeworkFiles/{newFileName}";

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
                return new SuccessDataResult<FileDetailDto>(new FileDetailDto()
                {
                    FilePath = filePath,
                    FileUrl = fileUrl
                }, Messages.FileCreated);
            }
        }

        public IResult Delete(string path)
        {
            File.SetAttributes(path, FileAttributes.Normal);
            File.Delete(path);
            return new SuccessResult(Messages.FileDeleted);
        }

        public IDataResult<FileDetailDto> Update(string oldFilePath, IFormFile file)
        {
            Delete(oldFilePath);
            Thread.Sleep(3000);
            return Add(file);
        }
    }
}
