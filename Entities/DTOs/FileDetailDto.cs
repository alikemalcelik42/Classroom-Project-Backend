using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FileDetailDto : IDto
    {
        public string FilePath { get; set; }
        public string FileUrl { get; set; }
    }
}
