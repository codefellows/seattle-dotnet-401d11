using Microsoft.Azure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageBlobUpload.Models
{
    public interface IImage
    {
        Task<CloudBlobContainer> GetContainer(string containerName);
        Task<CloudBlob> GetBlob(string imageName, string containerName);
        Task UploadFile(string containerName, string fileName, byte[] image, string contentType);

    }
}
