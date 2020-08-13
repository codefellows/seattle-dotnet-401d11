using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Auth;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ImageBlobUpload.Models
{
    public class ImageService : IImage
    {
        private IConfiguration _config;
        public CloudStorageAccount CloudStorageAccount { get; set; }
        public CloudBlobClient CloudBlobClient { get; set; }

        public ImageService(IConfiguration configuration)
        {
            _config = configuration;
            var storagecredentials = new StorageCredentials(_config["BlobAccountName"], _config["BlobKey"]);
            CloudStorageAccount = new CloudStorageAccount(storagecredentials, true);
            CloudBlobClient = CloudStorageAccount.CreateCloudBlobClient();
        }

        /*
         1. Connect your account (in the constructor)
         2. Get/Create the container 
         3. Create the Blob
         4. Push Blob to Container
         5. #Profit.
         */

        public async Task<CloudBlobContainer> GetContainer(string containerName)
        {
            // createing a reference to the existing container name
            CloudBlobContainer cbc = CloudBlobClient.GetContainerReference(containerName.ToLower());
            await cbc.CreateIfNotExistsAsync();

            await cbc.SetPermissionsAsync(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            return cbc;
        }

        public async Task<CloudBlob> GetBlob(string imageName, string containerName)
        {
            var container = await GetContainer(containerName);
            CloudBlob cb = container.GetBlobReference(imageName);

            return cb;
        }

        public async Task UploadFile(string containerName, string fileName, byte[] image, string contentType)
        {
            var container = await GetContainer(containerName);
            var blobreference = container.GetBlockBlobReference(fileName);
            blobreference.Properties.ContentType = contentType;
            await blobreference.UploadFromByteArrayAsync(image, 0, image.Length);
        }
    }
}
