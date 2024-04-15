using MYNEWS.Abstractions;

namespace MYNEWS.Services
{
    public class LocalStorageService : IStorageService
    {
        public LocalStorageService(IWebHostEnvironment env)
        {
            _storagePath = Path.Combine(env.WebRootPath, "uploads");
        }

        private readonly string _storagePath;

        public async Task DeleteFileAsync(string dirPath, string fileName)
        {

            if (!HasFile(dirPath, fileName))
            {
                throw new FileNotFoundException();
            }

            var path = Path.Combine(_storagePath, dirPath, fileName);

            await Task.Run(() => File.Delete(path));
        }

        public bool HasFile(string dirPath, string fileName)
        {
            var path = Path.Combine(_storagePath, dirPath, fileName);

            return File.Exists(path);
        }

        public Task UploadFileAsync(string dirPath, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task UploadFilesAsync(string dirPath, IFormFileCollection files)
        {
            throw new NotImplementedException();
        }
    }
}
