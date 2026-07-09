using System.Net.Http;
using System.Threading.Tasks;

namespace ScrabbleSK.Data
{
 
    public class FileService
    {
        private readonly HttpClient _httpClient;

        public FileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ReadFileAsync(string filePath)
        {
            return await _httpClient.GetStringAsync(filePath);
        }
    }

}
