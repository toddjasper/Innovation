using System.IO;

namespace Innovation.Voice.Win.UI
{
    public class FileHelper
    {
        public byte[] FileToBytes(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            var stream = File.OpenRead(filePath);
            var fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();

            return fileBytes;
        }
    }
}
