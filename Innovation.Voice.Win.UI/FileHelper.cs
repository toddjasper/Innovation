using System.IO;

namespace Innovation.Voice.Win.UI
{
    public class FileHelper
    {
        public readonly string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }

        public byte[] FileToBytes()
        {
            var stream = File.OpenRead(_filePath);
            var fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();

            return fileBytes;
        }
    }
}
