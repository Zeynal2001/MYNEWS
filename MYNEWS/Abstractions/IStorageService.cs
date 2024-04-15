namespace MYNEWS.Abstractions
{
    public interface IStorageService
    {
        Task UploadFileAsync(string dirPath, IFormFile file);
        Task UploadFilesAsync(string dirPath, IFormFileCollection files);
        bool HasFile(string dirPath, string fileName);
        Task DeleteFileAsync(string dirPath, string fileName);
    }
}
//Task<string> GetAsync(string key);
//Task SetAsync(string key, string value);
//Task DeleteAsync(string key);
//Task<IEnumerable<string>> GetKeysAsync();
//Task<IEnumerable<string>> GetValuesAsync();
//Task<IEnumerable<string>> ValuesAsync();
//Task<IEnumerable<string>> KeysAsync();