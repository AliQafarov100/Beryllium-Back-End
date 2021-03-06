using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Beryllium_Back_End.Extensions
{
    public static class FileExtension
    {
        public static bool IsGreater(this IFormFile file,int mb)
        {
            return file.Length > mb * 1024 * 1024;
        }
        
        public static bool IsContain(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool IsOkay(this IFormFile file, int mb)
        {
            return file.Length < 1024 * 1024 && file.ContentType.Contains("image");
        }
    }
}
